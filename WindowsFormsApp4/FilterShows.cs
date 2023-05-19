using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp4
{
    public partial class FilterShows : Form
    {

        public int currentUserId;

        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public FilterShows(int currentUserId)
        {
            this.currentUserId = currentUserId;
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ordb = "Data Source =ORCL; User Id=hr;Password=hr;";
            String cmdstr = "";

            if (radioButton1.Checked)
            {
                cmdstr = @"select * from SHAHIDSHOWS where SHAHIDSHOWS.TYPE = 'Movie'";
            }
            else if (radioButton2.Checked)
            {
                cmdstr = @"select * from SHAHIDSHOWS where SHAHIDSHOWS.TYPE = 'Series'";
            }
            adapter = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void save_Click_1(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavigationForm f = new NavigationForm(currentUserId);
            f.Show();
        }
    }
}
