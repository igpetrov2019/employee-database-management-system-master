﻿
namespace DeluxeNotebook
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
            email = new System.Windows.Forms.TextBox();
            passwordLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
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
            // email
            // 
            email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            email.Location = new System.Drawing.Point(342, 341);
            email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            email.Name = "email";
            email.Size = new System.Drawing.Size(271, 34);
            email.TabIndex = 20;
            email.KeyPress += email_id_KeyPress;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            passwordLabel.Location = new System.Drawing.Point(243, 405);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(90, 28);
            passwordLabel.TabIndex = 19;
            passwordLabel.Text = "Парола :";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emailLabel.Location = new System.Drawing.Point(243, 345);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(83, 28);
            emailLabel.TabIndex = 18;
            emailLabel.Text = "Имейл :";
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
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nameLabel.Location = new System.Drawing.Point(243, 285);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 28);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Име :";
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
            Controls.Add(nameLabel);
            Controls.Add(register_btn);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Deluxe Notebook";
            FormClosing += Register_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
    }
}