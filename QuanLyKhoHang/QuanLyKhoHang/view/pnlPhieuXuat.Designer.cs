﻿namespace QuanLyKhoHang.view
{
    partial class pnlPhieuXuat
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
            btnDangXuat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTimKiem = new TextBox();
            label1 = new Label();
            dgvPhieuXuat = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuat).BeginInit();
            SuspendLayout();
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.Location = new Point(711, 516);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(150, 45);
            btnDangXuat.TabIndex = 27;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(711, 127);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 45);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa phiếu xuất";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(711, 76);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 45);
            btnSua.TabIndex = 25;
            btnSua.Text = "Sửa thông tin";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(711, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 45);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm phiếu xuất";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(82, 25);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(587, 27);
            txtTimKiem.TabIndex = 23;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 22;
            label1.Text = "Tìm kiếm:";
            // 
            // dgvPhieuXuat
            // 
            dgvPhieuXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuXuat.Location = new Point(3, 70);
            dgvPhieuXuat.Name = "dgvPhieuXuat";
            dgvPhieuXuat.RowHeadersWidth = 51;
            dgvPhieuXuat.Size = new Size(666, 527);
            dgvPhieuXuat.TabIndex = 21;
            dgvPhieuXuat.ColumnHeaderMouseClick += dgvPhieuXuat_ColumnHeaderMouseClick;
            // 
            // pnlPhieuXuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDangXuat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(dgvPhieuXuat);
            Name = "pnlPhieuXuat";
            Size = new Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangXuat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTimKiem;
        private Label label1;
        private DataGridView dgvPhieuXuat;
    }
}
