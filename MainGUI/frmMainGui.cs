﻿using System.Timers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.Controller;
using ThuVien.DialogueBox;

namespace ThuVien.MainGUI
{
	public partial class frmMainGui : Form
	{
		NguoiDung user = new NguoiDung();
		Sach book = new Sach();

		private System.Timers.Timer _timer = null;
		public frmMainGui()
		{
			InitializeComponent();
		}

		private void loadData()
		{
			DataTable bookList = book.getBookList(null);
			gridThongTinSach.DataSource = bookList;
		}

		private void frmMainGui_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				DialogResult a = new DialogResult();
				a = MessageBox.Show("Bạn muốn thoát phần mềm?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (a == DialogResult.Yes)
				{
					user.SignOut();
					Application.Exit();
				}
				else
				{
					e.Cancel = true;
				}
			}
		}

		private void frmMainGui_Load(object sender, EventArgs e)
		{
			_timer = new System.Timers.Timer(500);
			_timer.Elapsed += systemTimer_Elapsed;
			tooltextTrangThai.Text = "Sẵn sàng";
			loadData();
			if (gridThongTinSach.Rows.Count > 0)
			{
				gridThongTinSach.ClearSelection();
			}
		}

		void systemTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			tooltextTrangThai.Text = "Sẵn sàng";
			_timer.Stop();
		}

		private void setStatus(string text)
		{
			tooltextTrangThai.Text = text;
			_timer.Start();
		}

		private void btnDienLaiSach_Click(object sender, EventArgs e)
		{
			txtTenSach.Text = "";
			txtTacGia.Text = "";
			txtLoaiSach.Text = "";
			numSoLuong.Value = 0;
			gridThongTinSach.ClearSelection();
		}

		private void btnTimSach_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTimSach.Text))
			{
				loadData();
			}
			else
			{
				DataTable searchBook = book.getBookList(txtTimSach.Text);
				gridThongTinSach.DataSource = searchBook;
			}

			if (gridThongTinSach.Rows.Count > 0)
			{
				gridThongTinSach.ClearSelection();
			}
		}

		private void btnThemSach_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtTacGia.Text) || string.IsNullOrEmpty(txtLoaiSach.Text))
			{
				MessageBox.Show("Vui lòng điền đủ các thông tin sách để thêm dữ liệu!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			try
			{
				book.addBook(txtTenSach.Text, txtTacGia.Text, txtLoaiSach.Text, Convert.ToInt32(numSoLuong.Value));
				setStatus("Thêm dữ liệu thành công");
				loadData();
				gridThongTinSach.ClearSelection();
				btnDienLaiSach_Click(null, null);
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnSuaSach_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = gridThongTinSach.CurrentRow;

			int id = Convert.ToInt32(row.Cells[0].Value.ToString());

			if (string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtTacGia.Text) || string.IsNullOrEmpty(txtLoaiSach.Text))
			{
				MessageBox.Show("Vui lòng chọn một sách ở bảng danh mục để sửa thông tin!", "Chưa chọn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			try
			{
				book.editBook(id, txtTenSach.Text, txtTacGia.Text, txtLoaiSach.Text, Convert.ToInt32(numSoLuong.Value));
				setStatus("Cập nhật thông tin thành công");
				loadData();
				gridThongTinSach.ClearSelection();
				btnDienLaiSach_Click(null, null);
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnXoaSach_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = gridThongTinSach.CurrentRow;

			int id = Convert.ToInt32(row.Cells[0].Value.ToString());

			if (string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtTacGia.Text) || string.IsNullOrEmpty(txtLoaiSach.Text))
			{
				MessageBox.Show("Vui lòng chọn một sách ở bảng danh mục để xóa thông tin!", "Chưa chọn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			DialogResult dialog = new DialogResult();
			dialog = MessageBox.Show("Bạn có muốn xóa quyển sách đã chọn?" + Environment.NewLine + "Thao tác này không thể hoàn tác!", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (dialog == DialogResult.Yes)
			{
				try
				{
					book.deleteBook(id);
					setStatus("Đã xóa thông tin sách");
					loadData();
					gridThongTinSach.ClearSelection();
					btnDienLaiSach_Click(null, null);
				}
				catch (SqlException ex)
				{
					MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

		}

		private void gridThongTinSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.gridThongTinSach.Rows[e.RowIndex];

				txtTenSach.Text = row.Cells[1].Value.ToString();
				txtTacGia.Text = row.Cells[2].Value.ToString();
				txtLoaiSach.Text = row.Cells[3].Value.ToString();
				numSoLuong.Value = Convert.ToInt32(row.Cells[4].Value.ToString());
			}
		}

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DialogueBox.PasswordChange.frmPasswordChange frm = new DialogueBox.PasswordChange.frmPasswordChange();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("Đổi mật khẩu thành công!" + Environment.NewLine + "Bạn sẽ đăng xuất khỏi hệ thống, vui lòng đăng nhập lại với mật khẩu mới.", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
				user.SignOut();
				this.Hide();
				frmSignIn m = new frmSignIn();
				m.ShowDialog();
			}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			user.SignOut();
			Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DialogResult dialogResult = new DialogResult();

			dialogResult = MessageBox.Show("Bạn muốn đăng xuất hệ thống quản lý?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (dialogResult == DialogResult.Yes)
			{
				user.SignOut();
				frmSignIn frm = new frmSignIn();
				this.Hide();
				frm.ShowDialog();
			}
        }
    }
}
