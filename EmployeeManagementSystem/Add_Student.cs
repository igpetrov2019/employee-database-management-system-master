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
    public partial class Add_Student : Form
    {
        public static string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public Add_Student()
        {
            InitializeComponent();
        }

        private void cancel_comp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student emp = new Student(true);
            emp.Show();
        }

        private void save_comp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into employee values('" + emp_id_txt.Text + "','" + emp_name_txt.Text + "','" + emp_dob_txt.Text + "','" + emp_doj_txt.Text + "','" + emp_addr_txt.Text + "','" + gender_txt.Text + "','" + Convert.ToInt32(emp_mobile_txt.Text) + "','" + proffesion.Text + "','" + teacher.Text + "','" + university.Text + "','" + work.Text + "');";
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = sqlCon.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Data Added Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry!Couldn't insert data.");
                this.Hide();
                Student emp = new Student(true);
                emp.Show();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            emp_id_txt.Text = "";
            emp_name_txt.Text = "";
            emp_dob_txt.Text = "";
            emp_doj_txt.Text = "";
            emp_addr_txt.Text = "";
            gender_txt.Text = "";
            emp_mobile_txt.Text = "";
        }

        private void Add_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
