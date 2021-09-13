
namespace ThuVien.MainGUI
{
    partial class frmMainGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainGui));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tooltextTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridThongTinSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimSach = new System.Windows.Forms.Button();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnDienLaiSach = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoaiSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.sốLiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userListToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.Image = global::ThuVien.Properties.Resources.icons8_administrator_male_48px;
            this.userListToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.userListToolStripMenuItem.Text = "Danh sách người dùng";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::ThuVien.Properties.Resources.icons8_key_2_48px;
            this.changePasswordToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.changePasswordToolStripMenuItem.Text = "Đổi mật khẩu";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::ThuVien.Properties.Resources.icons8_sign_out_48px;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.signOutToolStripMenuItem.Text = "Đăng xuất";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::ThuVien.Properties.Resources.icons8_exit_sign_48px;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sốLiệuToolStripMenuItem
            // 
            this.sốLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentListToolStripMenuItem});
            this.sốLiệuToolStripMenuItem.Name = "sốLiệuToolStripMenuItem";
            this.sốLiệuToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sốLiệuToolStripMenuItem.Text = "Số liệu";
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Image = global::ThuVien.Properties.Resources.icons8_details_48px;
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.studentListToolStripMenuItem.Text = "Danh sách Sinh Viên";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooltextTrangThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(949, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tooltextTrangThai
            // 
            this.tooltextTrangThai.Name = "tooltextTrangThai";
            this.tooltextTrangThai.Size = new System.Drawing.Size(934, 17);
            this.tooltextTrangThai.Spring = true;
            this.tooltextTrangThai.Text = "toolStripStatusLabel1";
            this.tooltextTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 603);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.gridThongTinSach);
            this.tabPage1.Controls.Add(this.btnTimSach);
            this.tabPage1.Controls.Add(this.txtTimSach);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh mục sách";
            // 
            // gridThongTinSach
            // 
            this.gridThongTinSach.AllowUserToAddRows = false;
            this.gridThongTinSach.AllowUserToDeleteRows = false;
            this.gridThongTinSach.AllowUserToResizeColumns = false;
            this.gridThongTinSach.AllowUserToResizeRows = false;
            this.gridThongTinSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThongTinSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.gridThongTinSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridThongTinSach.Location = new System.Drawing.Point(3, 206);
            this.gridThongTinSach.MultiSelect = false;
            this.gridThongTinSach.Name = "gridThongTinSach";
            this.gridThongTinSach.ReadOnly = true;
            this.gridThongTinSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridThongTinSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridThongTinSach.Size = new System.Drawing.Size(935, 368);
            this.gridThongTinSach.TabIndex = 11;
            this.gridThongTinSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridThongTinSach_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDSach";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSach";
            this.Column2.HeaderText = "Tên sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 340;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TacGia";
            this.Column3.HeaderText = "Tác giả";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LoaiSach";
            this.Column5.HeaderText = "Loại sách";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuong";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnTimSach
            // 
            this.btnTimSach.Location = new System.Drawing.Point(858, 167);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(75, 23);
            this.btnTimSach.TabIndex = 10;
            this.btnTimSach.Text = "Tìm kiếm";
            this.btnTimSach.UseVisualStyleBackColor = true;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // txtTimSach
            // 
            this.txtTimSach.Location = new System.Drawing.Point(87, 167);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(765, 22);
            this.txtTimSach.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemSach);
            this.groupBox1.Controls.Add(this.btnSuaSach);
            this.groupBox1.Controls.Add(this.btnXoaSach);
            this.groupBox1.Controls.Add(this.btnDienLaiSach);
            this.groupBox1.Controls.Add(this.numSoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLoaiSach);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(84, 113);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(75, 23);
            this.btnThemSach.TabIndex = 5;
            this.btnThemSach.Text = "Thêm mới";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Location = new System.Drawing.Point(165, 113);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(97, 23);
            this.btnSuaSach.TabIndex = 6;
            this.btnSuaSach.Text = "Sửa thông tin";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(268, 113);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSach.TabIndex = 7;
            this.btnXoaSach.Text = "Xóa";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnDienLaiSach
            // 
            this.btnDienLaiSach.Location = new System.Drawing.Point(349, 113);
            this.btnDienLaiSach.Name = "btnDienLaiSach";
            this.btnDienLaiSach.Size = new System.Drawing.Size(75, 23);
            this.btnDienLaiSach.TabIndex = 8;
            this.btnDienLaiSach.Text = "Điền lại";
            this.btnDienLaiSach.UseVisualStyleBackColor = true;
            this.btnDienLaiSach.Click += new System.EventHandler(this.btnDienLaiSach_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(574, 71);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 22);
            this.numSoLuong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng";
            // 
            // txtLoaiSach
            // 
            this.txtLoaiSach.Location = new System.Drawing.Point(574, 24);
            this.txtLoaiSach.Name = "txtLoaiSach";
            this.txtLoaiSach.Size = new System.Drawing.Size(355, 22);
            this.txtLoaiSach.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại sách";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(84, 70);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(406, 22);
            this.txtTacGia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tác giả";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(84, 24);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(406, 22);
            this.txtTenSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tìm tên sách";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mượn sách";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(941, 577);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trả sách";
            // 
            // frmMainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 652);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMainGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thư Viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainGui_FormClosing);
            this.Load += new System.EventHandler(this.frmMainGui_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốLiệuToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tooltextTrangThai;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoaiSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridThongTinSach;
        private System.Windows.Forms.Button btnTimSach;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnDienLaiSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}