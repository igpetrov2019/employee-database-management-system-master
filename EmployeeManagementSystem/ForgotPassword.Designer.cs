
namespace DeluxeNotebook
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            reset = new System.Windows.Forms.Button();
            password = new System.Windows.Forms.TextBox();
            email = new System.Windows.Forms.TextBox();
            newPasswordLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // reset
            // 
            reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            reset.Location = new System.Drawing.Point(334, 461);
            reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            reset.Name = "reset";
            reset.Size = new System.Drawing.Size(109, 45);
            reset.TabIndex = 22;
            reset.Text = "Промяна";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // password
            // 
            password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            password.Location = new System.Drawing.Point(413, 388);
            password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new System.Drawing.Size(260, 34);
            password.TabIndex = 21;
            // 
            // email
            // 
            email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            email.Location = new System.Drawing.Point(413, 328);
            email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            email.Name = "email";
            email.Size = new System.Drawing.Size(260, 34);
            email.TabIndex = 20;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            newPasswordLabel.Location = new System.Drawing.Point(269, 392);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new System.Drawing.Size(135, 28);
            newPasswordLabel.TabIndex = 19;
            newPasswordLabel.Text = "Нова парола:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emailLabel.Location = new System.Drawing.Point(269, 332);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(78, 28);
            emailLabel.TabIndex = 18;
            emailLabel.Text = "Имейл:";
            emailLabel.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(269, 68);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(404, 220);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // cancel
            // 
            cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cancel.Location = new System.Drawing.Point(496, 461);
            cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cancel.Name = "cancel";
            cancel.Size = new System.Drawing.Size(86, 45);
            cancel.TabIndex = 23;
            cancel.Text = "Отказ";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(896, 615);
            Controls.Add(cancel);
            Controls.Add(reset);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(newPasswordLabel);
            Controls.Add(emailLabel);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPassword";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Deluxe Notebook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancel;
    }
}