namespace EmployeeManagementSystem
{
    partial class AddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adduser_Status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adduser_btn = new System.Windows.Forms.Button();
            this.Signup_showpassword = new System.Windows.Forms.CheckBox();
            this.adduser_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adduser_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagebox = new System.Windows.Forms.PictureBox();
            this.Insert_img = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // adduser_Status
            // 
            this.adduser_Status.FormattingEnabled = true;
            this.adduser_Status.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Users"});
            this.adduser_Status.Location = new System.Drawing.Point(78, 449);
            this.adduser_Status.Name = "adduser_Status";
            this.adduser_Status.Size = new System.Drawing.Size(315, 24);
            this.adduser_Status.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(81, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Status";
            // 
            // adduser_btn
            // 
            this.adduser_btn.BackColor = System.Drawing.Color.Navy;
            this.adduser_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduser_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.adduser_btn.Location = new System.Drawing.Point(216, 499);
            this.adduser_btn.Name = "adduser_btn";
            this.adduser_btn.Size = new System.Drawing.Size(278, 46);
            this.adduser_btn.TabIndex = 30;
            this.adduser_btn.Text = "Add User";
            this.adduser_btn.UseVisualStyleBackColor = false;
            this.adduser_btn.Click += new System.EventHandler(this.adduser_btn_Click);
            // 
            // Signup_showpassword
            // 
            this.Signup_showpassword.AutoSize = true;
            this.Signup_showpassword.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_showpassword.ForeColor = System.Drawing.Color.Black;
            this.Signup_showpassword.Location = new System.Drawing.Point(265, 397);
            this.Signup_showpassword.Name = "Signup_showpassword";
            this.Signup_showpassword.Size = new System.Drawing.Size(128, 23);
            this.Signup_showpassword.TabIndex = 29;
            this.Signup_showpassword.Text = "Show Password ";
            this.Signup_showpassword.UseVisualStyleBackColor = true;
            this.Signup_showpassword.CheckedChanged += new System.EventHandler(this.Signup_showpassword_CheckedChanged);
            // 
            // adduser_password
            // 
            this.adduser_password.Location = new System.Drawing.Point(81, 369);
            this.adduser_password.Name = "adduser_password";
            this.adduser_password.PasswordChar = '*';
            this.adduser_password.Size = new System.Drawing.Size(312, 22);
            this.adduser_password.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Password";
            // 
            // adduser_username
            // 
            this.adduser_username.Location = new System.Drawing.Point(78, 298);
            this.adduser_username.Name = "adduser_username";
            this.adduser_username.Size = new System.Drawing.Size(315, 22);
            this.adduser_username.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(75, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(284, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Add Users";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources._912267_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(172, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // imagebox
            // 
            this.imagebox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imagebox.Location = new System.Drawing.Point(449, 298);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(218, 137);
            this.imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagebox.TabIndex = 34;
            this.imagebox.TabStop = false;
            // 
            // Insert_img
            // 
            this.Insert_img.BackColor = System.Drawing.Color.Navy;
            this.Insert_img.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_img.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Insert_img.Location = new System.Drawing.Point(449, 435);
            this.Insert_img.Name = "Insert_img";
            this.Insert_img.Size = new System.Drawing.Size(218, 46);
            this.Insert_img.TabIndex = 35;
            this.Insert_img.Text = "Insert Picture";
            this.Insert_img.UseVisualStyleBackColor = false;
            this.Insert_img.Click += new System.EventHandler(this.Insert_img_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Insert_img);
            this.Controls.Add(this.imagebox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adduser_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adduser_btn);
            this.Controls.Add(this.Signup_showpassword);
            this.Controls.Add(this.adduser_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adduser_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "AddUser";
            this.Size = new System.Drawing.Size(724, 609);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox adduser_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adduser_btn;
        private System.Windows.Forms.CheckBox Signup_showpassword;
        private System.Windows.Forms.TextBox adduser_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adduser_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imagebox;
        private System.Windows.Forms.Button Insert_img;
    }
}
