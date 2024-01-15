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
    public partial class Register : Form
    {
        public static string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=studentsdb;Integrated Security=True";

        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == "" || email.Text == "" || password.Text == "")
                {
                    throw new Exception("Invalid input");
                }
                SqlConnection con = new SqlConnection(ConnectionString);
                string sqlquery = "insert into [studentsdb].[dbo].[registration] values(@name, @emailid, @password, @isAdmin)";
                con.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
                sqlcomm.Parameters.AddWithValue("@name", name.Text);
                sqlcomm.Parameters.AddWithValue("@emailid", email.Text);
                sqlcomm.Parameters.AddWithValue("@password", password.Text);
                sqlcomm.Parameters.AddWithValue("@isAdmin", false);
                sqlcomm.ExecuteNonQuery();
                MessageBox.Show("Успешна регистрация!");
                con.Close();
                this.Hide();
                Login l = new Login();
                l.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невъзможна регистрация");
            }
        }

        private void email_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("позволени са само букви и цифри");
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("позволени са само букви и цифри");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
