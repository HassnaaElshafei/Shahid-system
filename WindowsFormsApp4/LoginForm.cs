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
    public partial class LoginForm : Form
    {

        string ordb = "Data Source =ORCL; User Id=hr;Password=hr;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            int currentUserId = -1;
            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetUserID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username", username.Text);
            cmd.Parameters.Add("UserPassword", passwordTextBox.Text);
            cmd.Parameters.Add("returnedId", OracleDbType.Int32).Direction = ParameterDirection.Output;
            //cmd.Parameters.Add("returnedId", currentUserId);
            cmd.ExecuteReader();
            currentUserId = int.Parse(cmd.Parameters["returnedID"].Value.ToString());

            if (currentUserId != -1)
            {
                MessageBox.Show("Login Successfully");
                NavigationForm f = new NavigationForm(currentUserId);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login" + currentUserId.ToString());

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.Show();
            this.Hide();
        }
    }
}
