﻿
namespace EmployeeManagementSystem
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            emp_btn = new System.Windows.Forms.Button();
            search_btn = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            label12 = new System.Windows.Forms.Label();
            emp_mobile_txt = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            gender_txt = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            emp_addr_txt = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            emp_doj_txt = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            emp_dob_txt = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            emp_name_txt = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            emp_id_txt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            mod_emp_btn = new System.Windows.Forms.Button();
            del_emp_btn = new System.Windows.Forms.Button();
            emp_grid = new System.Windows.Forms.DataGridView();
            panel2 = new System.Windows.Forms.Panel();
            label14 = new System.Windows.Forms.Label();
            add_emp_btn = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emp_grid).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(emp_btn);
            panel1.Controls.Add(search_btn);
            panel1.Location = new System.Drawing.Point(14, 16);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(280, 921);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            button1.Location = new System.Drawing.Point(90, 848);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(101, 44);
            button1.TabIndex = 8;
            button1.Text = "Отписване";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(14, 5);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(248, 169);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // emp_btn
            // 
            emp_btn.Location = new System.Drawing.Point(3, 266);
            emp_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emp_btn.Name = "emp_btn";
            emp_btn.Size = new System.Drawing.Size(272, 63);
            emp_btn.TabIndex = 4;
            emp_btn.Text = "Подробности за ученик";
            emp_btn.UseVisualStyleBackColor = true;
            emp_btn.Click += emp_btn_Click;
            // 
            // search_btn
            // 
            search_btn.Location = new System.Drawing.Point(3, 183);
            search_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            search_btn.Name = "search_btn";
            search_btn.Size = new System.Drawing.Size(272, 63);
            search_btn.TabIndex = 1;
            search_btn.Text = "Търсене";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel3.Controls.Add(label12);
            panel3.Controls.Add(emp_mobile_txt);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(gender_txt);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(emp_addr_txt);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(emp_doj_txt);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(emp_dob_txt);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(emp_name_txt);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(emp_id_txt);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(mod_emp_btn);
            panel3.Controls.Add(del_emp_btn);
            panel3.Controls.Add(emp_grid);
            panel3.Location = new System.Drawing.Point(301, 144);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(979, 792);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(582, 527);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(0, 28);
            label12.TabIndex = 40;
            // 
            // emp_mobile_txt
            // 
            emp_mobile_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emp_mobile_txt.Location = new System.Drawing.Point(753, 383);
            emp_mobile_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emp_mobile_txt.Name = "emp_mobile_txt";
            emp_mobile_txt.Size = new System.Drawing.Size(207, 34);
            emp_mobile_txt.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(582, 387);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 28);
            label5.TabIndex = 34;
            label5.Text = "Телефон";
            // 
            // gender_txt
            // 
            gender_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gender_txt.Location = new System.Drawing.Point(753, 336);
            gender_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gender_txt.Name = "gender_txt";
            gender_txt.Size = new System.Drawing.Size(207, 34);
            gender_txt.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(582, 340);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(49, 28);
            label6.TabIndex = 32;
            label6.Text = "Пол";
            // 
            // emp_addr_txt
            // 
            emp_addr_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emp_addr_txt.Location = new System.Drawing.Point(753, 289);
            emp_addr_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emp_addr_txt.Name = "emp_addr_txt";
            emp_addr_txt.Size = new System.Drawing.Size(207, 34);
            emp_addr_txt.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(582, 293);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(164, 28);
            label7.TabIndex = 30;
            label7.Text = "Адрес на ученик";
            // 
            // emp_doj_txt
            // 
            emp_doj_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emp_doj_txt.Location = new System.Drawing.Point(753, 243);
            emp_doj_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emp_doj_txt.MaxLength = 10;
            emp_doj_txt.Name = "emp_doj_txt";
            emp_doj_txt.ReadOnly = true;
            emp_doj_txt.Size = new System.Drawing.Size(207, 34);
            emp_doj_txt.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(582, 247);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(151, 28);
            label8.TabIndex = 28;
            label8.Text = "Завършил дата";
            // 
            // emp_dob_txt
            // 
            emp_dob_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emp_dob_txt.Location = new System.Drawing.Point(753, 196);
            emp_dob_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emp_dob_txt.MaxLength = 10;
            emp_dob_txt.Name = "emp_dob_txt";
            emp_dob_txt.ReadOnly = true;
            emp_dob_txt.Size = new System.Drawing.Size(207, 34);
            emp_dob_txt.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(582, 200);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(112, 28);
            label4.TabIndex = 26;
            label4.Text = "Приет дата";
            // 
            // emp_name_txt
            // 
            emp_name_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emp_name_txt.Location = new System.Drawing.Point(753, 148);
            emp_name_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emp_name_txt.Name = "emp_name_txt";
            emp_name_txt.Size = new System.Drawing.Size(207, 34);
            emp_name_txt.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(582, 152);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 28);
            label3.TabIndex = 24;
            label3.Text = "Име на ученик:";
            // 
            // emp_id_txt
            // 
            emp_id_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emp_id_txt.Location = new System.Drawing.Point(753, 102);
            emp_id_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emp_id_txt.Name = "emp_id_txt";
            emp_id_txt.Size = new System.Drawing.Size(207, 34);
            emp_id_txt.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(582, 106);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 28);
            label1.TabIndex = 20;
            label1.Text = "Номер: ";
            // 
            // mod_emp_btn
            // 
            mod_emp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mod_emp_btn.Location = new System.Drawing.Point(640, 716);
            mod_emp_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mod_emp_btn.Name = "mod_emp_btn";
            mod_emp_btn.Size = new System.Drawing.Size(148, 45);
            mod_emp_btn.TabIndex = 12;
            mod_emp_btn.Text = "Редактирай";
            mod_emp_btn.UseVisualStyleBackColor = true;
            mod_emp_btn.Click += mod_emp_btn_Click;
            // 
            // del_emp_btn
            // 
            del_emp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            del_emp_btn.Location = new System.Drawing.Point(807, 716);
            del_emp_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            del_emp_btn.Name = "del_emp_btn";
            del_emp_btn.Size = new System.Drawing.Size(109, 45);
            del_emp_btn.TabIndex = 11;
            del_emp_btn.Text = "Изтрий";
            del_emp_btn.UseVisualStyleBackColor = true;
            del_emp_btn.Click += del_emp_btn_Click;
            // 
            // emp_grid
            // 
            emp_grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            emp_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            emp_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emp_grid.Location = new System.Drawing.Point(37, 33);
            emp_grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emp_grid.Name = "emp_grid";
            emp_grid.RowHeadersWidth = 51;
            emp_grid.RowTemplate.Height = 25;
            emp_grid.Size = new System.Drawing.Size(534, 728);
            emp_grid.TabIndex = 10;
            emp_grid.CellClick += emp_grid_CellClick;
            emp_grid.CellContentClick += emp_grid_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(label14);
            panel2.Controls.Add(add_emp_btn);
            panel2.Location = new System.Drawing.Point(301, 16);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(979, 120);
            panel2.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(3, 5);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(693, 81);
            label14.TabIndex = 31;
            label14.Text = "Подробности за ученик";
            // 
            // add_emp_btn
            // 
            add_emp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            add_emp_btn.Location = new System.Drawing.Point(853, 28);
            add_emp_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            add_emp_btn.Name = "add_emp_btn";
            add_emp_btn.Size = new System.Drawing.Size(109, 45);
            add_emp_btn.TabIndex = 7;
            add_emp_btn.Text = "Добави";
            add_emp_btn.UseVisualStyleBackColor = true;
            add_emp_btn.Click += add_emp_btn_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaption;
            ClientSize = new System.Drawing.Size(1294, 953);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Student";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Employee Database Management System";
            FormClosing += Employee_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emp_grid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button emp_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView emp_grid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add_emp_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mod_emp_btn;
        private System.Windows.Forms.Button del_emp_btn;
        private System.Windows.Forms.TextBox emp_mobile_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gender_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emp_addr_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emp_doj_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emp_dob_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emp_name_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emp_id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
    }
}