
namespace ThuVien.DialogueBox
{
    partial class frmStudentList
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtSearchStudent = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gridDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.ToolStripButton();
            this.btnAddStudent = new System.Windows.Forms.ToolStripButton();
            this.btnEditStudent = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteStudent = new System.Windows.Forms.ToolStripButton();
            this.btnResetStudent = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSearchStudent,
            this.btnSearchStudent,
            this.toolStripSeparator1,
            this.btnAddStudent,
            this.btnEditStudent,
            this.btnDeleteStudent,
            this.btnResetStudent});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(250, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // gridDanhSachSinhVien
            // 
            this.gridDanhSachSinhVien.AllowUserToAddRows = false;
            this.gridDanhSachSinhVien.AllowUserToDeleteRows = false;
            this.gridDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridDanhSachSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridDanhSachSinhVien.Location = new System.Drawing.Point(0, 132);
            this.gridDanhSachSinhVien.Name = "gridDanhSachSinhVien";
            this.gridDanhSachSinhVien.ReadOnly = true;
            this.gridDanhSachSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDanhSachSinhVien.Size = new System.Drawing.Size(745, 318);
            this.gridDanhSachSinhVien.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sinh viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sinh viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.cmbGioiTinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenSinhVien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaSinhVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã sinh viên";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(106, 19);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(143, 20);
            this.txtMaSinhVien.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên sinh viên";
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Location = new System.Drawing.Point(332, 19);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(207, 20);
            this.txtTenSinhVien.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giới tính";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Location = new System.Drawing.Point(598, 19);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(141, 21);
            this.cmbGioiTinh.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(106, 59);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(633, 20);
            this.txtDiaChi.TabIndex = 10;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Image = global::ThuVien.Properties.Resources.icons8_search_48px_1;
            this.btnSearchStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(76, 22);
            this.btnSearchStudent.Text = "Tìm kiếm";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Image = global::ThuVien.Properties.Resources.icons8_add_48px_1;
            this.btnAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(81, 22);
            this.btnAddStudent.Text = "Thêm mới";
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Image = global::ThuVien.Properties.Resources.icons8_edit_48px;
            this.btnEditStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(98, 22);
            this.btnEditStudent.Text = "Sửa thông tin";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Image = global::ThuVien.Properties.Resources.icons8_delete_48px_1;
            this.btnDeleteStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(47, 22);
            this.btnDeleteStudent.Text = "Xóa";
            // 
            // btnResetStudent
            // 
            this.btnResetStudent.Image = global::ThuVien.Properties.Resources.icons8_reset_48px;
            this.btnResetStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResetStudent.Name = "btnResetStudent";
            this.btnResetStudent.Size = new System.Drawing.Size(66, 22);
            this.btnResetStudent.Text = "Điền lại";
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridDanhSachSinhVien);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sinh viên";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtSearchStudent;
        private System.Windows.Forms.ToolStripButton btnSearchStudent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddStudent;
        private System.Windows.Forms.ToolStripButton btnEditStudent;
        private System.Windows.Forms.ToolStripButton btnDeleteStudent;
        private System.Windows.Forms.DataGridView gridDanhSachSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.ToolStripButton btnResetStudent;
    }
}