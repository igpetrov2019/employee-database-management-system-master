
namespace EmployeeManagementSystem
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            panel1 = new System.Windows.Forms.Panel();
            add_emp_btn = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            emp_btn = new System.Windows.Forms.Button();
            search_btn = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            search_grid = new System.Windows.Forms.DataGridView();
            search_button = new System.Windows.Forms.Button();
            searchbar = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            label14 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)search_grid).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(add_emp_btn);
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
            // add_emp_btn
            // 
            add_emp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            add_emp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            add_emp_btn.Location = new System.Drawing.Point(5, 430);
            add_emp_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            add_emp_btn.Name = "add_emp_btn";
            add_emp_btn.Size = new System.Drawing.Size(272, 58);
            add_emp_btn.TabIndex = 9;
            add_emp_btn.Text = "Добави";
            add_emp_btn.UseVisualStyleBackColor = true;
            add_emp_btn.Click += add_emp_btn_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.DarkSalmon;
            button1.Location = new System.Drawing.Point(96, 857);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(95, 44);
            button1.TabIndex = 8;
            button1.Text = "Отписване";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(16, 5);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(248, 169);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // emp_btn
            // 
            emp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            emp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emp_btn.Location = new System.Drawing.Point(5, 263);
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
            search_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 64, 0);
            search_btn.FlatAppearance.BorderSize = 5;
            search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
            search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            search_btn.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            search_btn.Location = new System.Drawing.Point(3, 183);
            search_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            search_btn.Name = "search_btn";
            search_btn.Size = new System.Drawing.Size(272, 63);
            search_btn.TabIndex = 1;
            search_btn.Text = "Търсене";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel2.Controls.Add(search_grid);
            panel2.Controls.Add(search_button);
            panel2.Controls.Add(searchbar);
            panel2.Location = new System.Drawing.Point(301, 145);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(981, 792);
            panel2.TabIndex = 5;
            // 
            // search_grid
            // 
            search_grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            search_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            search_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            search_grid.Location = new System.Drawing.Point(19, 124);
            search_grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            search_grid.Name = "search_grid";
            search_grid.RowHeadersWidth = 51;
            search_grid.RowTemplate.Height = 25;
            search_grid.Size = new System.Drawing.Size(937, 648);
            search_grid.TabIndex = 2;
            search_grid.CellContentClick += search_grid_CellContentClick;
            // 
            // search_button
            // 
            search_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            search_button.Location = new System.Drawing.Point(619, 53);
            search_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            search_button.Name = "search_button";
            search_button.Size = new System.Drawing.Size(105, 39);
            search_button.TabIndex = 1;
            search_button.Text = "Търсене";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // searchbar
            // 
            searchbar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            searchbar.Location = new System.Drawing.Point(282, 53);
            searchbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            searchbar.Name = "searchbar";
            searchbar.Size = new System.Drawing.Size(316, 39);
            searchbar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(label14);
            panel3.Location = new System.Drawing.Point(302, 17);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(979, 120);
            panel3.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(3, 17);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(261, 81);
            label14.TabIndex = 32;
            label14.Text = "Търсене";
            // 
            // Search
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
            Name = "Search";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Employee Database Management System";
            FormClosing += Search_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)search_grid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button emp_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView search_grid;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add_emp_btn;
    }
}