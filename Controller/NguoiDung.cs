using System.Data;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.Controller
{
	public class NguoiDung
	{
		private Database db = new Database();
		/// <summary>
		/// Đăng nhập hệ thống quản lý
		/// </summary>
		/// <param name="TenDangNhap">Tên đăng nhập</param>
		/// <param name="MatKhau">Mật khẩu</param>
		public void SignIn(string TenDangNhap, string MatKhau)
		{
			SqlCommand cmd = new SqlCommand("HeThong_DangNhapHeThong", db.GetConnection());
			cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
			cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Đăng xuất hệ thống
		/// </summary>
		public void SignOut()
		{
			SqlCommand cmd = new SqlCommand("update DangNhap set HoatDong = 0 where HoatDong = 1", db.GetConnection());
			cmd.CommandType = CommandType.Text;
			cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Lấy danh sách người dùng trong hệ thống
		/// </summary>
		/// <param name="timkiem">Từ khóa tìm kiếm</param>
		/// <returns>Toàn bộ bảng danh sách người dùng, hoặc danh sách người dùng thỏa mãn từ khóa tìm kiếm</returns>
		public DataTable GetUserList(string timkiem)
		{
			DataTable userList = new DataTable();
			SqlCommand cmd = new SqlCommand("HeThong_LayDanhSachNguoiDung", db.GetConnection());
			if (string.IsNullOrEmpty(timkiem))
			{
				cmd.Parameters.AddWithValue("@timkiem", "");
			}
			else
			{
				cmd.Parameters.AddWithValue("@timkiem", timkiem);
			}
			cmd.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(userList);

			return userList;
		}

		/// <summary>
		/// Đổi mật khẩu tài khoản người dùng
		/// </summary>
		/// <param name="oldPassword">Mật khẩu cũ</param>
		/// <param name="newPassword">Mật khẩu mới</param>
		public void changePassword(string oldPassword, string newPassword)
		{
			SqlCommand cmd = new SqlCommand("HeThong_DoiMatKhau", db.GetConnection());
			cmd.Parameters.AddWithValue("@old", oldPassword);
			cmd.Parameters.AddWithValue("@new", newPassword);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Lấy trạng thái người dùng, dùng cho ComboBox của phần quản lý người dùng
		/// </summary>
		/// <returns>Trả lại danh sách trạng thái người dùng</returns>
		public DataTable GetAccountStatus()
		{
			DataTable statusList = new DataTable();
			SqlCommand cmd = new SqlCommand("select distinct TrangThai, case when TrangThai = 0 then N'Vô hiệu hóa' when TrangThai = 1 then N'Hoạt động' end as TrangThaiDich from DangNhap", db.GetConnection());

			cmd.CommandType = CommandType.Text;

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(statusList);

			return statusList;
		}

		/// <summary>
		/// Thêm người dùng mới vào CSDL
		/// </summary>
		/// <param name="userName">Tên đăng nhập</param>
		/// <param name="accountName">Tên đại diện</param>
		/// <param name="password">Mật khẩu</param>
		/// <param name="status">Trạng thái tài khoản (Vô hiệu hóa/Hoạt động)</param>
		public void addUser(string userName, string accountName, string password, int status)
		{
			SqlCommand command = new SqlCommand("HeThong_CapNhatNguoiDung", db.GetConnection());

			command.Parameters.AddWithValue("@IDNguoiDung", 0);
			command.Parameters.AddWithValue("@TenDangNhap", userName);
			command.Parameters.AddWithValue("@MatKhau", password);
			command.Parameters.AddWithValue("@TenDaiDien", accountName);
			command.Parameters.AddWithValue("@TrangThai", status);
			command.Parameters.AddWithValue("@MatKhauMoi", "");

			command.CommandType = CommandType.StoredProcedure;
			command.ExecuteNonQuery();
		}

		/// <summary>
		/// Sửa thông tin tài khoản người dùng hệ thống
		/// </summary>
		/// <param name="IDNguoiDung">ID người dùng</param>
		/// <param name="userName">Tên người dùng mới</param>
		/// <param name="accountName">Tên đại diện mới</param>
		/// <param name="oldPassword">Mật khẩu cũ</param>
		/// <param name="password">Mật khẩu mới</param>
		/// <param name="status">Trạng thái tài khoản (Vô hiệu hóa/Hoạt động)</param>
		public void editUser(int IDNguoiDung, string userName, string accountName, string oldPassword, string password, int status)
		{
			SqlCommand command = new SqlCommand("HeThong_CapNhatNguoiDung", db.GetConnection());

			command.Parameters.AddWithValue("@IDNguoiDung", IDNguoiDung);
			command.Parameters.AddWithValue("@TenDangNhap", userName);
			command.Parameters.AddWithValue("@MatKhau", oldPassword);
			command.Parameters.AddWithValue("@TenDaiDien", accountName);
			command.Parameters.AddWithValue("@TrangThai", status);
			command.Parameters.AddWithValue("@MatKhauMoi", password);

			command.CommandType = CommandType.StoredProcedure;
			command.ExecuteNonQuery();
		}

		/// <summary>
		/// Xóa tài khoản người dùng khỏi hệ thống
		/// </summary>
		/// <param name="IDNguoiDung">ID tài khoản cần xóa</param>
		public void deleteUser(int IDNguoiDung)
		{
			SqlCommand command = new SqlCommand("delete from DangNhap where ID = @id", db.GetConnection());

			command.Parameters.AddWithValue("@id", IDNguoiDung);
			command.CommandType = CommandType.Text;

			command.ExecuteNonQuery();
		}
	}
}
