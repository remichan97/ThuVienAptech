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
		SinhVien sv = new SinhVien();
		MuonSach muon = new MuonSach();
		TraSach tra = new TraSach();
		private System.Timers.Timer _timer = null;
		public frmMainGui()
		{
			InitializeComponent();
		}

		private void loadData()
		{
			//Dữ liệu phần danh mục sách:
			DataTable bookList = book.getBookList(null);
			gridThongTinSach.DataSource = bookList;
			//Dữ liệu phần mượn sách
			DataTable borrowList = muon.GetDanhMucMuonSach(null);
			gridThongTinMuonSach.DataSource = borrowList;
			DataTable borrowable = book.getBorrowableBooks();
			cmbSachMuon.DataSource = borrowable;
			cmbSachMuon.DisplayMember = "TenSach";
			cmbSachMuon.ValueMember = "IDSach";
			DataTable sinhVien = sv.GetStudentList(null);
			cmbTenNguoiMuon.DataSource = sinhVien;
			cmbTenNguoiMuon.DisplayMember = "TenSinhVien";
			cmbTenNguoiMuon.ValueMember = "MaSinhVien";
			cmbTenNguoiMuon.SelectedIndex = -1;
			//Dữ liệu phần trả sách:
			cmbTenNguoiTraSach.DataSource = sinhVien;
			cmbTenNguoiTraSach.DisplayMember = "TenSinhVien";
			cmbTenNguoiTraSach.ValueMember = "MaSinhVien";
			cmbTenNguoiTraSach.SelectedIndex = -1;
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
			_timer = new System.Timers.Timer(3000);
			_timer.Elapsed += systemTimer_Elapsed;
			tooltextTrangThai.Text = "Sẵn sàng";
			loadData();
			if (gridThongTinSach.Rows.Count > 0)
			{
				gridThongTinSach.ClearSelection();
			}
			cmbTenNguoiMuon.SelectedIndex = -1;
			cmbSachMuon.Selected = false;
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
					if (gridThongTinSach.Rows.Count > 0)
					{
						gridThongTinSach.ClearSelection();

					}
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

		private void userListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmUserList frm = new frmUserList();
			frm.ShowDialog();
		}

		private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmStudentList frm = new frmStudentList();
			frm.ShowDialog();
		}

		///Tab mượn sách:

		private void btnResetBorrowInfo_Click(object sender, EventArgs e)
		{
			txtGhiChu.Text = "";
			cmbTenNguoiMuon.SelectedIndex = -1;
			dateNgayMuon.Value = DateTime.Now;
			dateNgayTra.Value = DateTime.Now;
			gridChiTietSachMuon.Rows.Clear();
			gridChiTietSachMuon.Refresh();
		}

		private void btnAddBorrowInfo_Click(object sender, EventArgs e)
		{
			if (cmbTenNguoiMuon.SelectedIndex == -1 || gridChiTietSachMuon.Rows.Count == 0)
			{
				MessageBox.Show("Vui lòng điền các thông tin cần thiết trước khi thêm dữ liệu người mượn", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (dateNgayTra.Value < dateNgayMuon.Value)
			{
				MessageBox.Show("Bạn không thể cho sinh viên mượn sách đến ngày trước ngày hôm nay!", "Dữ liệu ngày giờ sai", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Dictionary<int, int> borrowBookList = new Dictionary<int, int>();
			for (int i = 0; i < gridChiTietSachMuon.Rows.Count; i++)
			{
				if (gridChiTietSachMuon.Rows[i].Cells[0].Value != null)
				{
					try
					{
						borrowBookList.Add(Convert.ToInt32(gridChiTietSachMuon.Rows[i].Cells[0].Value), Convert.ToInt32(gridChiTietSachMuon.Rows[i].Cells[1].Value));
					}
					catch (ArgumentException)
					{
						MessageBox.Show("Có sách bị trùng trong danh sách các đầu sách cần mượn của sinh viên. Vui lòng kiểm tra lại", "Trùng sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}

			DialogResult a = new DialogResult();

			string message = "Bạn sắp sửa thêm dữ liệu mượn sách của sinh viên." + Environment.NewLine + "Lưu ý rằng sau khi thêm, dữ liệu sẽ không thể sửa đổi hoặc bị xóa khỏi CSDL!" + Environment.NewLine + "Trước khi thêm dữ liệu vui lòng đảm bảo dữ liệu nhập vào là chính xác!" + Environment.NewLine + "Bạn có muốn thêm dữ liệu đã nhập vào CSDL?";
			a = MessageBox.Show(message, "Xác nhận thêm dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (a == DialogResult.Yes)
			{
				try
				{
					muon.muonSach(cmbTenNguoiMuon.SelectedValue.ToString(), dateNgayMuon.Value.ToShortDateString(), dateNgayTra.Value.ToShortDateString(), txtGhiChu.Text, borrowBookList);
					setStatus("Thêm thông tin người mượn thành công");
					loadData();
					gridThongTinMuonSach.ClearSelection();
					btnResetBorrowInfo_Click(null, null);
				}
				catch (SqlException ex)
				{
					MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void btnSearchBorrower_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtSearchBorrower.Text))
			{
				loadData();
			}
			else
			{
				DataTable brList = muon.GetDanhMucMuonSach(txtSearchBorrower.Text);
				gridThongTinMuonSach.DataSource = brList;
				if (gridThongTinMuonSach.Rows.Count > 0)
				{
					gridThongTinMuonSach.ClearSelection();
				}
			}
			if (String.IsNullOrEmpty(cmbTenNguoiMuon.Text)) cmbTenNguoiMuon.SelectedIndex = -1;
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (gridThongTinMuonSach.Rows.Count > 0)
			{
				gridThongTinMuonSach.ClearSelection();
			}
		}

		private void gridThongTinMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = gridThongTinMuonSach.CurrentRow;
				cmbTenNguoiMuon.SelectedIndex = cmbTenNguoiMuon.FindStringExact(row.Cells[1].Value.ToString());
				dateNgayMuon.Text = row.Cells[2].Value.ToString();
				dateNgayTra.Text = row.Cells[3].Value.ToString();
				txtGhiChu.Text = row.Cells[5].Value.ToString();
			}
		}

		private void cmbTenNguoiMuon_Leave(object sender, EventArgs e)
		{
			string test = cmbTenNguoiMuon.Text;
			if ((cmbTenNguoiMuon.SelectedIndex = cmbTenNguoiMuon.FindStringExact(test)) == -1)
			{
				cmbTenNguoiMuon.Text = "";
			}
		}

		private void cmbTenNguoiTraSach_Leave(object sender, EventArgs e)
		{
			string test = cmbTenNguoiTraSach.Text;
			if ((cmbTenNguoiTraSach.SelectedIndex = cmbTenNguoiTraSach.FindStringExact(test)) == -1)
			{
				cmbTenNguoiTraSach.Text = "";
			}
		}

		private void btnSearchReturn_Click(object sender, EventArgs e)
		{
			if (cmbTenNguoiTraSach.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn hoặc nhập tên sinh viên để tiến hành tìm kiếm", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
			}
			if (dateNgayTraReturn.Value < dateNgayMuonReturn.Value)
			{
				MessageBox.Show("Không thể mượn sách đến ngày trước ngày mượn", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			try
			{
				DataTable danhSachMuon = tra.timKiemThongTinNguoiMuon(cmbTenNguoiTraSach.SelectedValue.ToString(), dateNgayMuonReturn.Value.ToShortDateString(), dateNgayTraReturn.Value.ToShortDateString());
				gridChiTietTraSach.DataSource = danhSachMuon;
				gridChiTietTraSach.ClearSelection();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnResetReturn_Click(object sender, EventArgs e)
		{
			cmbTenNguoiTraSach.SelectedIndex = -1;
			dateNgayMuonReturn.Value = DateTime.Now;
			dateNgayTraReturn.Value = DateTime.Now;
			DataTable empty = tra.timKiemThongTinNguoiMuon(null, null, null);
			gridChiTietTraSach.DataSource = empty;
			radioReturnAll.Checked = false;
			radioReturnSelected.Checked = false;
			btnReturnBooks.Enabled = false;
		}

		private void btnReturnBooks_Click(object sender, EventArgs e)
		{
			if (cmbTenNguoiTraSach.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng điền các thông tin hoặc chọn các lựa chọn cần thiết để tiến hành thao tác trả sách!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (radioReturnAll.Checked)
			{
				Dictionary<int, int> returnAll = new Dictionary<int, int>();
				for (int i = 0; i < gridChiTietTraSach.Rows.Count; i++)
				{
					returnAll.Add(Convert.ToInt32(gridChiTietTraSach.Rows[i].Cells[6].Value), Convert.ToInt32(gridChiTietTraSach.Rows[i].Cells[5].Value));
				}

				DialogResult dialog = new DialogResult();

				string message = "Bạn sắp sửa thực hiện thao tác trả sách của sinh viên." + Environment.NewLine + "Nếu sinh viên làm mất sách, vui lòng không điền số lượng trả ở các đầu sách bị mất tại đây. Thay vào đó, bạn vui lòng sử dụng mẫu báo mất sách của phần mềm để thực hiện điều này." + Environment.NewLine + "Bạn có muốn tiếp tục thực hiện việc trả sách?";

				dialog = MessageBox.Show(message, "Xác nhận trả sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (dialog == DialogResult.Yes)
				{
					tra.traSach(cmbTenNguoiTraSach.SelectedValue.ToString(), dateNgayMuonReturn.Value.ToShortDateString(), dateNgayTraReturn.Value.ToShortDateString(), returnAll, 1);
					setStatus("Toàn bộ số sách đã mượn tính đến khoảng thời gian được chọn đã được trả");
					loadData();
					btnResetReturn_Click(null, null);
				}
			}
			else
			{
				Dictionary<int, int> returnSelected = new Dictionary<int, int>();
				for (int i = 0; i < gridChiTietTraSach.Rows.Count; i++)
				{
					if (gridChiTietTraSach.Rows[i].Cells[0].Value != null)
					{
						returnSelected.Add(Convert.ToInt32(gridChiTietTraSach.Rows[i].Cells[6].Value), Convert.ToInt32(gridChiTietTraSach.Rows[i].Cells[0].Value));
					}
				}

				DialogResult dialog = new DialogResult();

				string message = "Bạn sắp sửa thực hiện thao tác trả sách của sinh viên." + Environment.NewLine + "Nếu sinh viên làm mất sách, vui lòng không điền số lượng trả ở các đầu sách bị mất tại đây. Thay vào đó, bạn vui lòng sử dụng mẫu báo mất sách của phần mềm để thực hiện điều này." + Environment.NewLine + "Bạn có muốn tiếp tục thực hiện việc trả sách?";

				dialog = MessageBox.Show(message, "Xác nhận trả sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialog == DialogResult.Yes)
				{
					tra.traSach(cmbTenNguoiTraSach.SelectedValue.ToString(), dateNgayMuonReturn.Value.ToShortDateString(), dateNgayTraReturn.Value.ToShortDateString(), returnSelected, 2);
					setStatus("Số sách đã mượn tính đến khoảng thời gian được chọn đã được trả");
					loadData();
					btnResetReturn_Click(null, null);
				}
			}
		}

		private void radioReturnAll_CheckedChanged(object sender, EventArgs e)
		{
			btnReturnBooks.Enabled = true;

			if (radioReturnAll.Checked)
			{
				gridChiTietTraSach.Enabled = false;
				gridChiTietTraSach.ForeColor = SystemColors.ControlDark;
				for (int i = 0; i < gridChiTietTraSach.Rows.Count; i++)
				{
					gridChiTietTraSach.Rows[i].Cells[0].Value = "";
				}
			}
			else
			{
				gridChiTietTraSach.Enabled = true;
				gridChiTietTraSach.ForeColor = Color.Empty;
			}
		}

        private void radioReturnSelected_CheckedChanged(object sender, EventArgs e)
        {
			btnReturnBooks.Enabled = true;
		}

        private void reportLostBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DialogueBox.LostBook.frmLostBook lost = new DialogueBox.LostBook.frmLostBook();
			lost.ShowDialog();
        }

        private void linkLostBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			DialogueBox.LostBook.frmLostBook lost = new DialogueBox.LostBook.frmLostBook();
			lost.ShowDialog();
        }

        private void backupRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void restoreDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
