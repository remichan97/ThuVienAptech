
namespace ThuVien.DialogueBox
{
    partial class frmUserList
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
            this.txtSearchUser = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearchUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddUser = new System.Windows.Forms.ToolStripButton();
            this.btnEditUser = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSearchUser,
            this.btnSearchUser,
            this.toolStripSeparator1,
            this.btnAddUser,
            this.btnEditUser,
            this.btnDeleteUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(250, 25);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Image = global::ThuVien.Properties.Resources.icons8_search_48px_1;
            this.btnSearchUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(76, 22);
            this.btnSearchUser.Text = "Tìm kiếm";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::ThuVien.Properties.Resources.icons8_add_48px_1;
            this.btnAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(81, 22);
            this.btnAddUser.Text = "Thêm mới";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Image = global::ThuVien.Properties.Resources.icons8_edit_48px;
            this.btnEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(98, 22);
            this.btnEditUser.Text = "Sửa thông tin";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Image = global::ThuVien.Properties.Resources.icons8_delete_48px_1;
            this.btnDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(47, 22);
            this.btnDeleteUser.Text = "Xóa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 424);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách người dùng";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtSearchUser;
        private System.Windows.Forms.ToolStripButton btnSearchUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddUser;
        private System.Windows.Forms.ToolStripButton btnEditUser;
        private System.Windows.Forms.ToolStripButton btnDeleteUser;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}