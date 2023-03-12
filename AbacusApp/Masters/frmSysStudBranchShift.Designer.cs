﻿namespace AbacusApp.Masters
{
    partial class frmSysStudBranchShift
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
            this.cmbo_branches = new System.Windows.Forms.ComboBox();
            this.lbl_selectBranch = new System.Windows.Forms.Label();
            this.dgv_studInfo = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_shift = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbo_branches
            // 
            this.cmbo_branches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbo_branches.FormattingEnabled = true;
            this.cmbo_branches.Location = new System.Drawing.Point(912, 64);
            this.cmbo_branches.Name = "cmbo_branches";
            this.cmbo_branches.Size = new System.Drawing.Size(404, 40);
            this.cmbo_branches.TabIndex = 0;
            // 
            // lbl_selectBranch
            // 
            this.lbl_selectBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_selectBranch.AutoSize = true;
            this.lbl_selectBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_selectBranch.Location = new System.Drawing.Point(723, 59);
            this.lbl_selectBranch.Name = "lbl_selectBranch";
            this.lbl_selectBranch.Size = new System.Drawing.Size(173, 45);
            this.lbl_selectBranch.TabIndex = 1;
            this.lbl_selectBranch.Text = "Branches :";
            // 
            // dgv_studInfo
            // 
            this.dgv_studInfo.AllowUserToAddRows = false;
            this.dgv_studInfo.AllowUserToDeleteRows = false;
            this.dgv_studInfo.AllowUserToOrderColumns = true;
            this.dgv_studInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_studInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_studInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_studInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_studInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_studInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            this.dgv_studInfo.GridColor = System.Drawing.Color.White;
            this.dgv_studInfo.Location = new System.Drawing.Point(47, 182);
            this.dgv_studInfo.Name = "dgv_studInfo";
            this.dgv_studInfo.RowHeadersWidth = 60;
            this.dgv_studInfo.RowTemplate.Height = 41;
            this.dgv_studInfo.Size = new System.Drawing.Size(1269, 447);
            this.dgv_studInfo.TabIndex = 2;
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.MinimumWidth = 10;
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_shift
            // 
            this.btn_shift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shift.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_shift.Location = new System.Drawing.Point(1090, 679);
            this.btn_shift.Name = "btn_shift";
            this.btn_shift.Size = new System.Drawing.Size(226, 60);
            this.btn_shift.TabIndex = 3;
            this.btn_shift.Text = "Shift";
            this.btn_shift.UseVisualStyleBackColor = true;
            this.btn_shift.Click += new System.EventHandler(this.btn_shift_Click);
            // 
            // frmSysStudBranchShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 786);
            this.Controls.Add(this.btn_shift);
            this.Controls.Add(this.dgv_studInfo);
            this.Controls.Add(this.lbl_selectBranch);
            this.Controls.Add(this.cmbo_branches);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysStudBranchShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift Branch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSysStudBranchShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbo_branches;
        private Label lbl_selectBranch;
        private DataGridView dgv_studInfo;
        private DataGridViewCheckBoxColumn select;
        private Button btn_shift;
    }
}