﻿namespace EmployeeManagementSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add_Manager = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Salary_btn = new System.Windows.Forms.Button();
            this.Employee_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.greent_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.addUser1 = new EmployeeManagementSystem.AddUser();
            this.employee1 = new EmployeeManagementSystem.Employee();
            this.manager1 = new EmployeeManagementSystem.Manager();
            this.dashboard1 = new EmployeeManagementSystem.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.X);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Management System";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(1057, 9);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(31, 29);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Add_Manager);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Logout_btn);
            this.panel2.Controls.Add(this.Salary_btn);
            this.panel2.Controls.Add(this.Employee_btn);
            this.panel2.Controls.Add(this.Dashboard_btn);
            this.panel2.Controls.Add(this.greent_user);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 557);
            this.panel2.TabIndex = 1;
            // 
            // Add_Manager
            // 
            this.Add_Manager.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources._6821002_removebg_preview;
            this.Add_Manager.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Add_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Manager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_Manager.Location = new System.Drawing.Point(12, 308);
            this.Add_Manager.Name = "Add_Manager";
            this.Add_Manager.Size = new System.Drawing.Size(191, 51);
            this.Add_Manager.TabIndex = 7;
            this.Add_Manager.Text = "Add Manager";
            this.Add_Manager.UseVisualStyleBackColor = true;
            this.Add_Manager.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "User";
            // 
            // Logout_btn
            // 
            this.Logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Logout_btn.Location = new System.Drawing.Point(12, 506);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(191, 39);
            this.Logout_btn.TabIndex = 4;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Salary_btn
            // 
            this.Salary_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Salary_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salary_btn.Location = new System.Drawing.Point(12, 422);
            this.Salary_btn.Name = "Salary_btn";
            this.Salary_btn.Size = new System.Drawing.Size(191, 51);
            this.Salary_btn.TabIndex = 5;
            this.Salary_btn.Text = "Add Users";
            this.Salary_btn.UseVisualStyleBackColor = true;
            this.Salary_btn.Click += new System.EventHandler(this.Salary_btn_Click);
            // 
            // Employee_btn
            // 
            this.Employee_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Employee_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Employee_btn.Location = new System.Drawing.Point(12, 365);
            this.Employee_btn.Name = "Employee_btn";
            this.Employee_btn.Size = new System.Drawing.Size(191, 51);
            this.Employee_btn.TabIndex = 4;
            this.Employee_btn.Text = "Add Employee";
            this.Employee_btn.UseVisualStyleBackColor = true;
            this.Employee_btn.Click += new System.EventHandler(this.Employee_btn_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources._6821002_removebg_preview;
            this.Dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dashboard_btn.Location = new System.Drawing.Point(12, 252);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(191, 51);
            this.Dashboard_btn.TabIndex = 3;
            this.Dashboard_btn.Text = "DashBoard";
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // greent_user
            // 
            this.greent_user.AutoSize = true;
            this.greent_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greent_user.Location = new System.Drawing.Point(35, 184);
            this.greent_user.Name = "greent_user";
            this.greent_user.Size = new System.Drawing.Size(141, 29);
            this.greent_user.TabIndex = 2;
            this.greent_user.Text = "Well Come";
            this.greent_user.Click += new System.EventHandler(this.greent_user_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.png_clipart_computer_icons_user_early_onset_dementia_support_group_login_customer_advisory_group_friend_icon_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(29, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.manager1);
            this.panel3.Controls.Add(this.employee1);
            this.panel3.Controls.Add(this.addUser1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(217, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 557);
            this.panel3.TabIndex = 2;
            // 
            // addUser1
            // 
            this.addUser1.Location = new System.Drawing.Point(0, 0);
            this.addUser1.Name = "addUser1";
            this.addUser1.Size = new System.Drawing.Size(883, 557);
            this.addUser1.TabIndex = 0;
            // 
            // employee1
            // 
            this.employee1.Location = new System.Drawing.Point(0, 0);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(950, 600);
            this.employee1.TabIndex = 1;
            // 
            // manager1
            // 
            this.manager1.Location = new System.Drawing.Point(0, -1);
            this.manager1.Name = "manager1";
            this.manager1.Size = new System.Drawing.Size(900, 560);
            this.manager1.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, -1);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(900, 556);
            this.dashboard1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Label greent_user;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Salary_btn;
        private System.Windows.Forms.Button Employee_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_Manager;
        private Dashboard dashboard1;
        private Manager manager1;
        private Employee employee1;
        private AddUser addUser1;
    }
}