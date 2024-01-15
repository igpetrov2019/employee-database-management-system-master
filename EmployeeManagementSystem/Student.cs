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
    public partial class Student : Form
    {
        public static string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=studentsdb;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public static string student_id_old;
        bool userIsAdmin = false;

        public Student(bool isAdmin)
        {
            InitializeComponent();
            loadData();
            add_emp_btn.Visible = isAdmin;
            del_emp_btn.Visible = isAdmin;
            mod_emp_btn.Visible = isAdmin;
            userIsAdmin = isAdmin;
        }

        public void loadData()
        {
            sqlCon.Open();
            string q = "Select e.student_id,e.student_name,e.student_in,e.student_out,e.student_address,e.gender,e.student_phone from employee e";
            SqlDataAdapter sqlDa = new SqlDataAdapter(q, sqlCon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            emp_grid.DataSource = dtbl;
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

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mod_emp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update employee set student_id='" + student_id_txt.Text + "',student_name='" + student_name_txt.Text + "',student_address='" + emp_addr_txt.Text + "',gender='" + gender_txt.Text + "', student_phone=" + Convert.ToInt32(student_phone_txt.Text) + " where student_id='" + student_id_old + "';";
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = sqlCon.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Updated Successfully.");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry!Couldn't update.");
            }
        }

        private void emp_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                student_id_txt.Text = emp_grid.SelectedRows[0].Cells[0].Value.ToString();
                student_name_txt.Text = emp_grid.SelectedRows[0].Cells[2].Value.ToString();
                student_in_txt.Text = emp_grid.SelectedRows[0].Cells[3].Value.ToString();
                student_out_txt.Text = emp_grid.SelectedRows[0].Cells[4].Value.ToString();
                emp_addr_txt.Text = emp_grid.SelectedRows[0].Cells[5].Value.ToString();
                gender_txt.Text = emp_grid.SelectedRows[0].Cells[6].Value.ToString();
                student_phone_txt.Text = emp_grid.SelectedRows[0].Cells[7].Value.ToString();
                student_id_old = emp_grid.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void add_emp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Student ae = new Add_Student();
            ae.Show();
        }

        private void del_emp_btn_Click(object sender, EventArgs e)
        {
            //try
            //{
            sqlCon.Open();
            SqlCommand cmd1 = sqlCon.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from employee where student_id='" + student_id_old + "';";
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            MessageBox.Show("Deleted Successfully.");
            loadData();
            //}
            /*catch (Exception ex)
            {
                MessageBox.Show("Sorry!Couldn't delete.");
            }*/
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void emp_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
