﻿namespace AbacusApp.RegMasters
{
    partial class frmRegStud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_midName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_addr = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_middleName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_contactNo = new System.Windows.Forms.TextBox();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.rbtn_other = new System.Windows.Forms.RadioButton();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_addr = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_netBalence = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.dgv_fees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fees)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(37, 69);
            this.lbl_firstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(70, 15);
            this.lbl_firstName.TabIndex = 0;
            this.lbl_firstName.Text = "First Name :";
            // 
            // lbl_midName
            // 
            this.lbl_midName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_midName.AutoSize = true;
            this.lbl_midName.Location = new System.Drawing.Point(20, 99);
            this.lbl_midName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_midName.Name = "lbl_midName";
            this.lbl_midName.Size = new System.Drawing.Size(85, 15);
            this.lbl_midName.TabIndex = 1;
            this.lbl_midName.Text = "Middle Name :";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(39, 128);
            this.lbl_lastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(69, 15);
            this.lbl_lastName.TabIndex = 2;
            this.lbl_lastName.Text = "Last Name :";
            // 
            // lbl_contact
            // 
            this.lbl_contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Location = new System.Drawing.Point(410, 67);
            this.lbl_contact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(74, 15);
            this.lbl_contact.TabIndex = 3;
            this.lbl_contact.Text = "Contact No :";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(431, 99);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(53, 15);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "E - Mail :";
            // 
            // lbl_addr
            // 
            this.lbl_addr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_addr.AutoSize = true;
            this.lbl_addr.Location = new System.Drawing.Point(431, 130);
            this.lbl_addr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_addr.Name = "lbl_addr";
            this.lbl_addr.Size = new System.Drawing.Size(55, 15);
            this.lbl_addr.TabIndex = 5;
            this.lbl_addr.Text = "Address :";
            // 
            // lbl_gender
            // 
            this.lbl_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(57, 157);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(51, 15);
            this.lbl_gender.TabIndex = 6;
            this.lbl_gender.Text = "Gender :";
            // 
            // lbl_city
            // 
            this.lbl_city.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(454, 160);
            this.lbl_city.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(34, 15);
            this.lbl_city.TabIndex = 7;
            this.lbl_city.Text = "City :";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_firstName.Location = new System.Drawing.Point(124, 68);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(262, 23);
            this.txt_firstName.TabIndex = 9;
            // 
            // txt_middleName
            // 
            this.txt_middleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_middleName.Location = new System.Drawing.Point(124, 98);
            this.txt_middleName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_middleName.Name = "txt_middleName";
            this.txt_middleName.Size = new System.Drawing.Size(262, 23);
            this.txt_middleName.TabIndex = 10;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_lastName.Location = new System.Drawing.Point(124, 125);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(262, 23);
            this.txt_lastName.TabIndex = 11;
            // 
            // txt_contactNo
            // 
            this.txt_contactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contactNo.Location = new System.Drawing.Point(501, 65);
            this.txt_contactNo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_contactNo.Name = "txt_contactNo";
            this.txt_contactNo.Size = new System.Drawing.Size(262, 23);
            this.txt_contactNo.TabIndex = 13;
            // 
            // rbtn_male
            // 
            this.rbtn_male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(124, 155);
            this.rbtn_male.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(51, 19);
            this.rbtn_male.TabIndex = 14;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // rbtn_female
            // 
            this.rbtn_female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(220, 155);
            this.rbtn_female.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(63, 19);
            this.rbtn_female.TabIndex = 15;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            this.rbtn_female.CheckedChanged += new System.EventHandler(this.rbtn_female_CheckedChanged);
            // 
            // rbtn_other
            // 
            this.rbtn_other.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_other.AutoSize = true;
            this.rbtn_other.Location = new System.Drawing.Point(328, 155);
            this.rbtn_other.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbtn_other.Name = "rbtn_other";
            this.rbtn_other.Size = new System.Drawing.Size(55, 19);
            this.rbtn_other.TabIndex = 16;
            this.rbtn_other.TabStop = true;
            this.rbtn_other.Text = "Other";
            this.rbtn_other.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.Location = new System.Drawing.Point(501, 98);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(262, 23);
            this.txt_email.TabIndex = 17;
            // 
            // txt_addr
            // 
            this.txt_addr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_addr.Location = new System.Drawing.Point(501, 129);
            this.txt_addr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_addr.Name = "txt_addr";
            this.txt_addr.Size = new System.Drawing.Size(262, 23);
            this.txt_addr.TabIndex = 18;
            // 
            // txt_city
            // 
            this.txt_city.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_city.Location = new System.Drawing.Point(501, 159);
            this.txt_city.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(262, 23);
            this.txt_city.TabIndex = 19;
            // 
            // btn_register
            // 
            this.btn_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_register.Location = new System.Drawing.Point(658, 425);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(113, 29);
            this.btn_register.TabIndex = 21;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_header.Location = new System.Drawing.Point(328, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(160, 40);
            this.lbl_header.TabIndex = 22;
            this.lbl_header.Text = "Admission";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(511, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Net Amount :";
            // 
            // lbl_discount
            // 
            this.lbl_discount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_discount.Location = new System.Drawing.Point(23, 404);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(71, 17);
            this.lbl_discount.TabIndex = 28;
            this.lbl_discount.Text = "Discount :";
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_total.Location = new System.Drawing.Point(23, 373);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(47, 17);
            this.lbl_total.TabIndex = 27;
            this.lbl_total.Text = "Total :";
            // 
            // txt_netBalence
            // 
            this.txt_netBalence.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_netBalence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_netBalence.Location = new System.Drawing.Point(617, 373);
            this.txt_netBalence.Margin = new System.Windows.Forms.Padding(0);
            this.txt_netBalence.Name = "txt_netBalence";
            this.txt_netBalence.ReadOnly = true;
            this.txt_netBalence.Size = new System.Drawing.Size(155, 23);
            this.txt_netBalence.TabIndex = 26;
            // 
            // txt_discount
            // 
            this.txt_discount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_discount.Location = new System.Drawing.Point(162, 403);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(155, 23);
            this.txt_discount.TabIndex = 25;
            // 
            // txt_total
            // 
            this.txt_total.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_total.Location = new System.Drawing.Point(162, 372);
            this.txt_total.Margin = new System.Windows.Forms.Padding(0);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(155, 23);
            this.txt_total.TabIndex = 24;
            // 
            // dgv_fees
            // 
            this.dgv_fees.AllowUserToAddRows = false;
            this.dgv_fees.AllowUserToDeleteRows = false;
            this.dgv_fees.AllowUserToResizeColumns = false;
            this.dgv_fees.AllowUserToResizeRows = false;
            this.dgv_fees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_fees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_fees.BackgroundColor = System.Drawing.Color.White;
            this.dgv_fees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_fees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_fees.GridColor = System.Drawing.Color.White;
            this.dgv_fees.Location = new System.Drawing.Point(12, 197);
            this.dgv_fees.Name = "dgv_fees";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_fees.RowHeadersWidth = 62;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_fees.RowTemplate.Height = 25;
            this.dgv_fees.Size = new System.Drawing.Size(760, 147);
            this.dgv_fees.TabIndex = 23;
            // 
            // frmRegStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_discount);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.txt_netBalence);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.dgv_fees);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_addr);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.rbtn_other);
            this.Controls.Add(this.rbtn_female);
            this.Controls.Add(this.rbtn_male);
            this.Controls.Add(this.txt_contactNo);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_middleName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_addr);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_midName);
            this.Controls.Add(this.lbl_firstName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegStud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.frmRegStud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_firstName;
        private Label lbl_midName;
        private Label lbl_lastName;
        private Label lbl_contact;
        private Label lbl_email;
        private Label lbl_addr;
        private Label lbl_gender;
        private Label lbl_city;
        private TextBox txt_firstName;
        private TextBox txt_middleName;
        private TextBox txt_lastName;
        private TextBox txt_contactNo;
        private RadioButton rbtn_male;
        private RadioButton rbtn_female;
        private RadioButton rbtn_other;
        private TextBox txt_email;
        private TextBox txt_addr;
        private TextBox txt_city;
        private Button btn_register;
        private Label lbl_header;
        private Label label3;
        private Label lbl_discount;
        private Label lbl_total;
        private TextBox txt_netBalence;
        private TextBox txt_discount;
        private TextBox txt_total;
        private DataGridView dgv_fees;
    }
}