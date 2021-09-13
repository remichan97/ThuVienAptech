
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
            this.btnSearchStudent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStudent = new System.Windows.Forms.ToolStripButton();
            this.btnEditStudent = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteStudent = new System.Windows.Forms.ToolStripButton();
            this.gridDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachSinhVien)).BeginInit();
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
            this.btnDeleteStudent});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(250, 25);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Image = global::ThuVien.Properties.Resources.icons8_search_48px_1;
            this.btnSearchStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(76, 22);
            this.btnSearchStudent.Text = "Tìm kiếm";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // gridDanhSachSinhVien
            // 
            this.gridDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDanhSachSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridDanhSachSinhVien.Location = new System.Drawing.Point(0, 25);
            this.gridDanhSachSinhVien.Name = "gridDanhSachSinhVien";
            this.gridDanhSachSinhVien.Size = new System.Drawing.Size(800, 425);
            this.gridDanhSachSinhVien.TabIndex = 1;
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}