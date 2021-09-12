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
        Database db = new Database();
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
    }
}
