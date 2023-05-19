using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        CrystalReport3 cr;
        public int userId;
        public Form1(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport3(); 
            //foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues )
        }
        private void GenerateReport_Click(object sender, EventArgs e)
        {
            
            cr.SetParameterValue(0, Convert.ToDateTime(StartDate.Text));
            cr.SetParameterValue(1, Convert.ToDateTime(EndDate.Text));
            crystalReportViewer1.ReportSource = cr;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavigationForm f = new NavigationForm(userId);
            f.Show();
        }
    }
}
