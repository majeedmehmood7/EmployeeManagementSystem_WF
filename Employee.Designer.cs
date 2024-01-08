namespace EmployeeManagementSystem
{
    partial class Employee
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
            this.add_employee_import_btn = new System.Windows.Forms.Button();
            this.add_employee_clear_btn = new System.Windows.Forms.Button();
            this.add_employee_delete_btn = new System.Windows.Forms.Button();
            this.add_employee_update_btn = new System.Windows.Forms.Button();
            this.add_employee_Add_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.add_employee_number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.add_employee_gender = new System.Windows.Forms.ComboBox();
            this.add_employee_name = new System.Windows.Forms.TextBox();
            this.employee_name = new System.Windows.Forms.Label();
            this.add_employee_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_employee_position = new System.Windows.Forms.ComboBox();
            this.employee_picture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_picture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_employee_import_btn
            // 
            this.add_employee_import_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_employee_import_btn.Location = new System.Drawing.Point(728, 119);
            this.add_employee_import_btn.Name = "add_employee_import_btn";
            this.add_employee_import_btn.Size = new System.Drawing.Size(138, 30);
            this.add_employee_import_btn.TabIndex = 15;
            this.add_employee_import_btn.Text = "Insert ";
            this.add_employee_import_btn.UseVisualStyleBackColor = false;
            // 
            // add_employee_clear_btn
            // 
            this.add_employee_clear_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_employee_clear_btn.Location = new System.Drawing.Point(555, 155);
            this.add_employee_clear_btn.Name = "add_employee_clear_btn";
            this.add_employee_clear_btn.Size = new System.Drawing.Size(157, 46);
            this.add_employee_clear_btn.TabIndex = 14;
            this.add_employee_clear_btn.Text = "Clear";
            this.add_employee_clear_btn.UseVisualStyleBackColor = false;
            // 
            // add_employee_delete_btn
            // 
            this.add_employee_delete_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_employee_delete_btn.Location = new System.Drawing.Point(374, 155);
            this.add_employee_delete_btn.Name = "add_employee_delete_btn";
            this.add_employee_delete_btn.Size = new System.Drawing.Size(157, 46);
            this.add_employee_delete_btn.TabIndex = 13;
            this.add_employee_delete_btn.Text = "Delete";
            this.add_employee_delete_btn.UseVisualStyleBackColor = false;
            // 
            // add_employee_update_btn
            // 
            this.add_employee_update_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_employee_update_btn.Location = new System.Drawing.Point(192, 155);
            this.add_employee_update_btn.Name = "add_employee_update_btn";
            this.add_employee_update_btn.Size = new System.Drawing.Size(157, 46);
            this.add_employee_update_btn.TabIndex = 12;
            this.add_employee_update_btn.Text = "Update";
            this.add_employee_update_btn.UseVisualStyleBackColor = false;
            // 
            // add_employee_Add_button
            // 
            this.add_employee_Add_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_employee_Add_button.Location = new System.Drawing.Point(9, 155);
            this.add_employee_Add_button.Name = "add_employee_Add_button";
            this.add_employee_Add_button.Size = new System.Drawing.Size(157, 46);
            this.add_employee_Add_button.TabIndex = 11;
            this.add_employee_Add_button.Text = "Add";
            this.add_employee_Add_button.UseVisualStyleBackColor = false;
            this.add_employee_Add_button.Click += new System.EventHandler(this.add_employee_Add_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Position";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // add_employee_number
            // 
            this.add_employee_number.Location = new System.Drawing.Point(487, 13);
            this.add_employee_number.Name = "add_employee_number";
            this.add_employee_number.Size = new System.Drawing.Size(220, 22);
            this.add_employee_number.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone Number";
            // 
            // add_employee_gender
            // 
            this.add_employee_gender.FormattingEnabled = true;
            this.add_employee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.add_employee_gender.Location = new System.Drawing.Point(135, 109);
            this.add_employee_gender.Name = "add_employee_gender";
            this.add_employee_gender.Size = new System.Drawing.Size(220, 24);
            this.add_employee_gender.TabIndex = 5;
            // 
            // add_employee_name
            // 
            this.add_employee_name.Location = new System.Drawing.Point(135, 59);
            this.add_employee_name.Name = "add_employee_name";
            this.add_employee_name.Size = new System.Drawing.Size(220, 22);
            this.add_employee_name.TabIndex = 3;
            // 
            // employee_name
            // 
            this.employee_name.AutoSize = true;
            this.employee_name.Location = new System.Drawing.Point(13, 59);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(68, 16);
            this.employee_name.TabIndex = 2;
            this.employee_name.Text = "Full Name";
            // 
            // add_employee_id
            // 
            this.add_employee_id.Location = new System.Drawing.Point(135, 16);
            this.add_employee_id.Name = "add_employee_id";
            this.add_employee_id.Size = new System.Drawing.Size(220, 22);
            this.add_employee_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.add_employee_position);
            this.panel2.Controls.Add(this.add_employee_import_btn);
            this.panel2.Controls.Add(this.add_employee_clear_btn);
            this.panel2.Controls.Add(this.add_employee_delete_btn);
            this.panel2.Controls.Add(this.add_employee_update_btn);
            this.panel2.Controls.Add(this.add_employee_Add_button);
            this.panel2.Controls.Add(this.employee_picture);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.add_employee_number);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.add_employee_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.add_employee_name);
            this.panel2.Controls.Add(this.employee_name);
            this.panel2.Controls.Add(this.add_employee_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 213);
            this.panel2.TabIndex = 3;
            // 
            // add_employee_position
            // 
            this.add_employee_position.FormattingEnabled = true;
            this.add_employee_position.Items.AddRange(new object[] {
            "Frontend",
            "HR",
            "Backend",
            "DevOps"});
            this.add_employee_position.Location = new System.Drawing.Point(487, 53);
            this.add_employee_position.Name = "add_employee_position";
            this.add_employee_position.Size = new System.Drawing.Size(220, 24);
            this.add_employee_position.TabIndex = 16;
            // 
            // employee_picture
            // 
            this.employee_picture.BackColor = System.Drawing.Color.DimGray;
            this.employee_picture.Location = new System.Drawing.Point(728, 8);
            this.employee_picture.Name = "employee_picture";
            this.employee_picture.Size = new System.Drawing.Size(133, 117);
            this.employee_picture.TabIndex = 10;
            this.employee_picture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 294);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 218);
            this.dataGridView1.TabIndex = 1;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status.Location = new System.Drawing.Point(492, 109);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(220, 24);
            this.status.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Status";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(950, 600);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_employee_import_btn;
        private System.Windows.Forms.Button add_employee_clear_btn;
        private System.Windows.Forms.Button add_employee_delete_btn;
        private System.Windows.Forms.Button add_employee_update_btn;
        private System.Windows.Forms.Button add_employee_Add_button;
        private System.Windows.Forms.PictureBox employee_picture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox add_employee_number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox add_employee_gender;
        private System.Windows.Forms.TextBox add_employee_name;
        private System.Windows.Forms.Label employee_name;
        private System.Windows.Forms.TextBox add_employee_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox add_employee_position;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label3;
    }
}
