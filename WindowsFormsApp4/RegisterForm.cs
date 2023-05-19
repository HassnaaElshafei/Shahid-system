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

    public partial class RegisterForm : Form
    {
        string ordb = "Data Source =ORCL; User Id=hr;Password=hr;";

        public RegisterForm()
        {
            InitializeComponent();
        }



        private void label4_Click(object sender, EventArgs e)
        {
            LoginForm L = new LoginForm();
            L.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand selectCmd = new OracleCommand();
            selectCmd.Connection = conn;
            selectCmd.CommandText = "select count(*) from Users";
            selectCmd.CommandType = CommandType.Text;
            OracleDataReader dr = selectCmd.ExecuteReader();
            int unmberOfUsers=0;
            if (dr.Read())
                unmberOfUsers = int.Parse(dr[0].ToString());
            dr.Close();

            OracleCommand detectCmd = new OracleCommand();
            detectCmd.Connection = conn;
            detectCmd.CommandText = "select userId from Users where memName = :username";
            detectCmd.Parameters.Add("username",username.Text);
            detectCmd.CommandType = CommandType.Text;
            dr = detectCmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("You are already registered");
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Users (userId,memname, userpassword) values (:UserID,:username, :userPassword)";
                cmd.Parameters.Add("UserID", unmberOfUsers + 1);
                cmd.Parameters.Add("username", username.Text);
                cmd.Parameters.Add("userPassword", passwordTextBox.Text);
                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("Registered Sussesfully");
                }
                else
                {
                    MessageBox.Show("Invalid Registered");
                }
            }



        }
    }
}
