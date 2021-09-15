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

namespace ThuVien.DialogueBox
{
	public partial class frmUserList : Form
	{
		NguoiDung user = new NguoiDung();

		public frmUserList()
		{
			InitializeComponent();
		}

		private void loadData()
		{
			DataTable accountStatus = user.GetAccountStatus();
			cmbUserStatus.DataSource = accountStatus;
			cmbUserStatus.DisplayMember = "TrangThaiDich";
			cmbUserStatus.ValueMember = "TrangThai";
			DataTable userList = user.GetUserList(null);
			gridDanhSachNguoiDung.DataSource = userList;
			gridDanhSachNguoiDung.ClearSelection();
		}

		private void checkRevealPassword_CheckedChanged(object sender, EventArgs e)
		{
			txtOldPassword.UseSystemPasswordChar = txtNewPassword.UseSystemPasswordChar = txtVerify.UseSystemPasswordChar = checkHidePassword.Checked;
		}

		private void frmUserList_Load(object sender, EventArgs e)
		{
			checkRevealPassword_CheckedChanged(null, null);
			loadData();
		}

		private void btnSearchUser_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtSearchUser.Text))
			{
				loadData();
			}
			else
			{
				DataTable userList = user.GetUserList(txtSearchUser.Text);
				gridDanhSachNguoiDung.DataSource = userList;
				gridDanhSachNguoiDung.ClearSelection();
			}

		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtAccountName.Text))
			{
				MessageBox.Show("Vui lòng điền đủ các thông tin để tiến hành thêm người dùng", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (!string.IsNullOrEmpty(txtOldPassword.Text))
			{
				MessageBox.Show("Chưa tạo người dùng mới, không thể tiến hành đổi mật khẩu cho nguời dùng này!" + Environment.NewLine + "Vui lòng điền ô mật khẩu mới và xác nhận mật khẩu và bỏ trống ô nhập mật khẩu cũ!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtNewPassword.Text != txtVerify.Text)
			{
				MessageBox.Show("Xác nhận mật khẩu không khớp. Vui lòng kiểm tra lại!", "Xác nhận mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			try
			{
				user.addUser(txtUserName.Text, txtAccountName.Text, txtNewPassword.Text, Convert.ToInt32(cmbUserStatus.SelectedValue));
				MessageBox.Show("Thêm dữ liệu thành công", "Thành công");
				loadData();
				btnResetUser_Click(null, null);
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnEditUser_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtAccountName.Text) || string.IsNullOrEmpty(txtOldPassword.Text))
			{
				MessageBox.Show("Vui lòng chọn một người dùng ở danh sách để tiến hành sửa thông tin.", "Chưa chọn người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtNewPassword.Text != txtVerify.Text)
			{
				MessageBox.Show("Xác nhận mật khẩu không khớp. Vui lòng kiểm tra lại!", "Xác nhận mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			DataGridViewRow row = gridDanhSachNguoiDung.CurrentRow;

			string id = row.Cells[0].Value.ToString();
			try
			{
				user.editUser(Convert.ToInt32(id), txtUserName.Text, txtAccountName.Text, txtOldPassword.Text, txtNewPassword.Text, Convert.ToInt32(cmbUserStatus.SelectedValue));
				MessageBox.Show("Cập nhật thông tin thành công", "Thành công");
				loadData();
				btnResetUser_Click(null, null);
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnDeleteUser_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtOldPassword.Text) || string.IsNullOrEmpty(txtAccountName.Text))
			{
				MessageBox.Show("Vui lòng điền đủ các thông tin để tiến hành xóa người dùng", "Chưa chọn người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			try
			{
				DataGridViewRow row = gridDanhSachNguoiDung.CurrentRow;
				string id = row.Cells[0].Value.ToString();
				DialogResult dialog = new DialogResult();

				dialog = MessageBox.Show("Bạn có chắc muốn xóa người dùng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (dialog == DialogResult.Yes)
				{
					user.deleteUser(Convert.ToInt32(id));
					MessageBox.Show("Đã xóa thông tin người dùng", "Xóa thành công");
					loadData();
					btnResetUser_Click(null, null);
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnResetUser_Click(object sender, EventArgs e)
		{
			txtUserName.Text = "";
			txtAccountName.Text = "";
			txtOldPassword.Text = "";
			txtNewPassword.Text = "";
			txtVerify.Text = "";
			cmbUserStatus.SelectedIndex = cmbUserStatus.FindStringExact("Vô hiệu hóa");
		}

		private void gridDanhSachNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = gridDanhSachNguoiDung.CurrentRow;
			if (e.RowIndex >= 0)
			{
				txtUserName.Text = row.Cells[1].Value.ToString();
				txtOldPassword.Text = row.Cells[2].Value.ToString();
				txtAccountName.Text = row.Cells[3].Value.ToString();
				cmbUserStatus.SelectedIndex = cmbUserStatus.FindStringExact(row.Cells[4].Value.ToString());
			}
		}
	}
}
