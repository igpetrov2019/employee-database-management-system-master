
namespace EmployeeManagementSystem
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            register_btn = new System.Windows.Forms.Button();
            password = new System.Windows.Forms.TextBox();
            email_id = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            name = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // register_btn
            // 
            register_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            register_btn.Location = new System.Drawing.Point(402, 461);
            register_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            register_btn.Name = "register_btn";
            register_btn.Size = new System.Drawing.Size(150, 45);
            register_btn.TabIndex = 22;
            register_btn.Text = "Регистрация";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // password
            // 
            password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            password.Location = new System.Drawing.Point(342, 401);
            password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new System.Drawing.Size(271, 34);
            password.TabIndex = 21;
            password.TextChanged += password_TextChanged;
            password.KeyPress += password_KeyPress;
            // 
            // email_id
            // 
            email_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            email_id.Location = new System.Drawing.Point(342, 341);
            email_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            email_id.Name = "email_id";
            email_id.Size = new System.Drawing.Size(271, 34);
            email_id.TabIndex = 20;
            email_id.KeyPress += email_id_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(243, 405);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 28);
            label2.TabIndex = 19;
            label2.Text = "Парола :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(243, 345);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 28);
            label1.TabIndex = 18;
            label1.Text = "Имейл :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(245, 50);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(368, 197);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(243, 285);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 28);
            label3.TabIndex = 23;
            label3.Text = "Име :";
            // 
            // name
            // 
            name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            name.Location = new System.Drawing.Point(342, 281);
            name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new System.Drawing.Size(271, 34);
            name.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(508, 549);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(130, 20);
            label4.TabIndex = 28;
            label4.Text = "за да се впишете.";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(485, 549);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(29, 20);
            linkLabel1.TabIndex = 27;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "тук";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(277, 549);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(216, 20);
            label5.TabIndex = 26;
            label5.Text = "Вече имате акаунт? Кликнете ";
            // 
            // Register
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaption;
            ClientSize = new System.Drawing.Size(896, 615);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(register_btn);
            Controls.Add(password);
            Controls.Add(email_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Employee Database Management System";
            FormClosing += Register_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
    }
}