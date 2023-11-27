using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Search : Form
    {
        public static string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True";
        bool userIsAdmin = false;
        public Search(bool isAdmin)
        {
            InitializeComponent();
            add_emp_btn.Visible = isAdmin;
            userIsAdmin = isAdmin;
        }

        private void emp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student emp = new Student(userIsAdmin);
            emp.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search s = new Search(false);
            s.Show();
        }


        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string sqlquery = "select * from [employeedb]. [dbo].[employee] where [emp_id] ='" + searchbar.Text + "  ' OR [emp_name] ='" + searchbar.Text + "' OR [emp_address] ='" + searchbar.Text + "' OR [gender] ='" + searchbar.Text + "';";
            con.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con); SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            search_grid.DataSource = dt;
            con.Close();
        }

        private void search_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void add_emp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Student ae = new Add_Student();
            ae.Show();
        }
    }
}
