using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DeluxeNotebook
{
    public partial class ForgotPassword : Form
    {
        public static string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=studentsdb;Integrated Security=True";

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (email.Text == "" || password.Text == "")
                {
                    throw new Exception("Невалидни данни");
                }
                SqlConnection sqlCon = new SqlConnection(ConnectionString);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update registration set password='" + password.Text + "' where emailid='" + email.Text + "';";
                cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = sqlCon.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from [studentsdb].[dbo].[registration] where password='" + password.Text + "' and emailid='" + email.Text + "';";
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd1.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Успешно рестартиране на парола!");
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                }
                else
                {
                    MessageBox.Show("Невалиден имейл или парола!");
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невалиден имейл или парола!");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
