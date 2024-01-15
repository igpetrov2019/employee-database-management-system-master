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
    public partial class Add_Student : Form
    {
        public static string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=studentsdb;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public Add_Student()
        {
            InitializeComponent();
        }

        private void cancel_comp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student(true);
            student.Show();
        }

        private void save_comp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into student values('" + student_name_txt.Text + "','" + student_in_txt.Text + "','" + student_out_txt.Text + "','" + emp_addr_txt.Text + "','" + gender_txt.Text + "','" + student_phone_txt.Text + "','" + proffesion.Text + "','" + teacher.Text + "','" + work.Text + "','" + university.Text + "');";
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Данните са записани успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка! Неуспешно записване на данни!");
                this.Hide();
                Student student = new Student(true);
                student.Show();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            student_name_txt.Text = "";
            student_in_txt.Text = "";
            student_out_txt.Text = "";
            emp_addr_txt.Text = "";
            gender_txt.Text = "";
            student_phone_txt.Text = "";
            work.Text = "";
            university.Text = "";
            teacher.Text = "";
        }

        private void Add_Student_FormClosing(object sender, FormClosingEventArgs e)
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
