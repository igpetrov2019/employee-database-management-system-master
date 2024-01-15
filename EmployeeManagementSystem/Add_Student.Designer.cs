
namespace DeluxeNotebook
{
    partial class Add_Student
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
            panel2 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            cancel_comp_btn = new System.Windows.Forms.Button();
            student_phone_txt = new System.Windows.Forms.TextBox();
            studentPhoneLabel = new System.Windows.Forms.Label();
            studentGenderLabel = new System.Windows.Forms.Label();
            emp_addr_txt = new System.Windows.Forms.TextBox();
            studentAddressLabel = new System.Windows.Forms.Label();
            studentOutLabel = new System.Windows.Forms.Label();
            studentInLabel = new System.Windows.Forms.Label();
            student_name_txt = new System.Windows.Forms.TextBox();
            studentNameLabel = new System.Windows.Forms.Label();
            clear = new System.Windows.Forms.Button();
            save_comp_btn = new System.Windows.Forms.Button();
            university = new System.Windows.Forms.TextBox();
            studentLearninglabel = new System.Windows.Forms.Label();
            teacher = new System.Windows.Forms.TextBox();
            studentTeacherLabel = new System.Windows.Forms.Label();
            proffesion = new System.Windows.Forms.TextBox();
            studentProffesionLabel = new System.Windows.Forms.Label();
            work = new System.Windows.Forms.TextBox();
            studentWorkLabel = new System.Windows.Forms.Label();
            gender_txt = new System.Windows.Forms.ListBox();
            student_in_txt = new System.Windows.Forms.DateTimePicker();
            student_out_txt = new System.Windows.Forms.DateTimePicker();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cancel_comp_btn);
            panel2.Location = new System.Drawing.Point(14, 16);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(869, 120);
            panel2.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(3, 19);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(704, 81);
            label5.TabIndex = 30;
            label5.Text = "Въведи данни за ученик";
            label5.Click += label5_Click;
            // 
            // cancel_comp_btn
            // 
            cancel_comp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cancel_comp_btn.Location = new System.Drawing.Point(728, 41);
            cancel_comp_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cancel_comp_btn.Name = "cancel_comp_btn";
            cancel_comp_btn.Size = new System.Drawing.Size(109, 45);
            cancel_comp_btn.TabIndex = 29;
            cancel_comp_btn.Text = "Назад";
            cancel_comp_btn.UseVisualStyleBackColor = true;
            cancel_comp_btn.Click += cancel_comp_btn_Click;
            // 
            // student_phone_txt
            // 
            student_phone_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            student_phone_txt.Location = new System.Drawing.Point(442, 460);
            student_phone_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            student_phone_txt.Name = "student_phone_txt";
            student_phone_txt.Size = new System.Drawing.Size(207, 34);
            student_phone_txt.TabIndex = 61;
            // 
            // studentPhoneLabel
            // 
            studentPhoneLabel.AutoSize = true;
            studentPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentPhoneLabel.Location = new System.Drawing.Point(236, 464);
            studentPhoneLabel.Name = "studentPhoneLabel";
            studentPhoneLabel.Size = new System.Drawing.Size(91, 28);
            studentPhoneLabel.TabIndex = 60;
            studentPhoneLabel.Text = "Телефон";
            // 
            // studentGenderLabel
            // 
            studentGenderLabel.AutoSize = true;
            studentGenderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentGenderLabel.Location = new System.Drawing.Point(236, 418);
            studentGenderLabel.Name = "studentGenderLabel";
            studentGenderLabel.Size = new System.Drawing.Size(49, 28);
            studentGenderLabel.TabIndex = 58;
            studentGenderLabel.Text = "Пол";
            // 
            // emp_addr_txt
            // 
            emp_addr_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emp_addr_txt.Location = new System.Drawing.Point(442, 367);
            emp_addr_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emp_addr_txt.Name = "emp_addr_txt";
            emp_addr_txt.Size = new System.Drawing.Size(207, 34);
            emp_addr_txt.TabIndex = 57;
            // 
            // studentAddressLabel
            // 
            studentAddressLabel.AutoSize = true;
            studentAddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentAddressLabel.Location = new System.Drawing.Point(236, 371);
            studentAddressLabel.Name = "studentAddressLabel";
            studentAddressLabel.Size = new System.Drawing.Size(67, 28);
            studentAddressLabel.TabIndex = 56;
            studentAddressLabel.Text = "Адрес";
            // 
            // studentOutLabel
            // 
            studentOutLabel.AutoSize = true;
            studentOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentOutLabel.Location = new System.Drawing.Point(236, 324);
            studentOutLabel.Name = "studentOutLabel";
            studentOutLabel.Size = new System.Drawing.Size(151, 28);
            studentOutLabel.TabIndex = 54;
            studentOutLabel.Text = "Завършил дата";
            // 
            // studentInLabel
            // 
            studentInLabel.AutoSize = true;
            studentInLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentInLabel.Location = new System.Drawing.Point(236, 278);
            studentInLabel.Name = "studentInLabel";
            studentInLabel.Size = new System.Drawing.Size(146, 28);
            studentInLabel.TabIndex = 52;
            studentInLabel.Text = "Постъпил дата";
            // 
            // student_name_txt
            // 
            student_name_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            student_name_txt.Location = new System.Drawing.Point(442, 226);
            student_name_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            student_name_txt.Name = "student_name_txt";
            student_name_txt.Size = new System.Drawing.Size(207, 34);
            student_name_txt.TabIndex = 51;
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentNameLabel.Location = new System.Drawing.Point(236, 230);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(148, 28);
            studentNameLabel.TabIndex = 50;
            studentNameLabel.Text = "Име на ученик";
            // 
            // clear
            // 
            clear.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            clear.Location = new System.Drawing.Point(478, 739);
            clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            clear.Name = "clear";
            clear.Size = new System.Drawing.Size(125, 45);
            clear.TabIndex = 71;
            clear.Text = "Изчисти";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // save_comp_btn
            // 
            save_comp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            save_comp_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            save_comp_btn.Location = new System.Drawing.Point(313, 739);
            save_comp_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            save_comp_btn.Name = "save_comp_btn";
            save_comp_btn.Size = new System.Drawing.Size(109, 45);
            save_comp_btn.TabIndex = 70;
            save_comp_btn.Text = "Запис";
            save_comp_btn.UseVisualStyleBackColor = true;
            save_comp_btn.Click += save_comp_btn_Click;
            // 
            // university
            // 
            university.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            university.Location = new System.Drawing.Point(442, 595);
            university.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            university.Name = "university";
            university.Size = new System.Drawing.Size(207, 34);
            university.TabIndex = 79;
            // 
            // studentLearninglabel
            // 
            studentLearninglabel.AutoSize = true;
            studentLearninglabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentLearninglabel.Location = new System.Drawing.Point(236, 599);
            studentLearninglabel.Name = "studentLearninglabel";
            studentLearninglabel.Size = new System.Drawing.Size(62, 28);
            studentLearninglabel.TabIndex = 78;
            studentLearninglabel.Text = "Учи в";
            // 
            // teacher
            // 
            teacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            teacher.Location = new System.Drawing.Point(442, 549);
            teacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            teacher.Name = "teacher";
            teacher.Size = new System.Drawing.Size(207, 34);
            teacher.TabIndex = 77;
            // 
            // studentTeacherLabel
            // 
            studentTeacherLabel.AutoSize = true;
            studentTeacherLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentTeacherLabel.Location = new System.Drawing.Point(236, 553);
            studentTeacherLabel.Name = "studentTeacherLabel";
            studentTeacherLabel.Size = new System.Drawing.Size(202, 28);
            studentTeacherLabel.TabIndex = 76;
            studentTeacherLabel.Text = "Класен ръководител";
            // 
            // proffesion
            // 
            proffesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            proffesion.Location = new System.Drawing.Point(442, 502);
            proffesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            proffesion.Name = "proffesion";
            proffesion.Size = new System.Drawing.Size(207, 34);
            proffesion.TabIndex = 75;
            // 
            // studentProffesionLabel
            // 
            studentProffesionLabel.AutoSize = true;
            studentProffesionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentProffesionLabel.Location = new System.Drawing.Point(236, 506);
            studentProffesionLabel.Name = "studentProffesionLabel";
            studentProffesionLabel.Size = new System.Drawing.Size(132, 28);
            studentProffesionLabel.TabIndex = 74;
            studentProffesionLabel.Text = "Специалност";
            // 
            // work
            // 
            work.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            work.Location = new System.Drawing.Point(442, 637);
            work.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            work.Name = "work";
            work.Size = new System.Drawing.Size(207, 34);
            work.TabIndex = 81;
            // 
            // studentWorkLabel
            // 
            studentWorkLabel.AutoSize = true;
            studentWorkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentWorkLabel.Location = new System.Drawing.Point(236, 641);
            studentWorkLabel.Name = "studentWorkLabel";
            studentWorkLabel.Size = new System.Drawing.Size(77, 28);
            studentWorkLabel.TabIndex = 80;
            studentWorkLabel.Text = "Работи";
            // 
            // gender_txt
            // 
            gender_txt.FormattingEnabled = true;
            gender_txt.ItemHeight = 20;
            gender_txt.Items.AddRange(new object[] { "мъж", "жена" });
            gender_txt.Location = new System.Drawing.Point(442, 408);
            gender_txt.Name = "gender_txt";
            gender_txt.Size = new System.Drawing.Size(207, 44);
            gender_txt.TabIndex = 82;
            // 
            // student_in_txt
            // 
            student_in_txt.Location = new System.Drawing.Point(444, 280);
            student_in_txt.Name = "student_in_txt";
            student_in_txt.Size = new System.Drawing.Size(207, 27);
            student_in_txt.TabIndex = 83;
            // 
            // student_out_txt
            // 
            student_out_txt.Location = new System.Drawing.Point(444, 326);
            student_out_txt.Name = "student_out_txt";
            student_out_txt.Size = new System.Drawing.Size(207, 27);
            student_out_txt.TabIndex = 84;
            // 
            // Add_Student
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(896, 829);
            Controls.Add(student_out_txt);
            Controls.Add(student_in_txt);
            Controls.Add(gender_txt);
            Controls.Add(work);
            Controls.Add(studentWorkLabel);
            Controls.Add(university);
            Controls.Add(studentLearninglabel);
            Controls.Add(teacher);
            Controls.Add(studentTeacherLabel);
            Controls.Add(proffesion);
            Controls.Add(studentProffesionLabel);
            Controls.Add(clear);
            Controls.Add(save_comp_btn);
            Controls.Add(student_phone_txt);
            Controls.Add(studentPhoneLabel);
            Controls.Add(studentGenderLabel);
            Controls.Add(emp_addr_txt);
            Controls.Add(studentAddressLabel);
            Controls.Add(studentOutLabel);
            Controls.Add(studentInLabel);
            Controls.Add(student_name_txt);
            Controls.Add(studentNameLabel);
            Controls.Add(panel2);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Add_Student";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Deluxe Notebook";
            FormClosing += Add_Student_FormClosing;
            Load += Add_Student_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancel_comp_btn;
        private System.Windows.Forms.TextBox student_phone_txt;
        private System.Windows.Forms.Label studentPhoneLabel;
        private System.Windows.Forms.Label studentGenderLabel;
        private System.Windows.Forms.TextBox emp_addr_txt;
        private System.Windows.Forms.Label studentAddressLabel;
        private System.Windows.Forms.Label studentOutLabel;
        private System.Windows.Forms.Label studentInLabel;
        private System.Windows.Forms.TextBox student_name_txt;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save_comp_btn;
        private System.Windows.Forms.TextBox university;
        private System.Windows.Forms.Label studentLearninglabel;
        private System.Windows.Forms.TextBox teacher;
        private System.Windows.Forms.Label studentTeacherLabel;
        private System.Windows.Forms.TextBox proffesion;
        private System.Windows.Forms.Label studentProffesionLabel;
        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.Label studentWorkLabel;
        private System.Windows.Forms.ListBox gender_txt;
        private System.Windows.Forms.DateTimePicker student_in_txt;
        private System.Windows.Forms.DateTimePicker student_out_txt;
    }
}