using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.Controller
{
    public class Sach
    {
        Database db = new Database();


        /// <summary>
        /// Lấy danh mục sách đang có trong thư viện
        /// </summary>
        /// <param name="timkiem">Từ khóa tìm kiếm, tìm theo tên sách,, dùng sp "Sach_DanhMucSach" để query</param>
        /// <returns>Toàn bộ danh mục sách, hoặc danh mục sách thỏa mãn từ khóa tìm kiếm</returns>
        public DataTable getBookList(string timkiem)
        {
            DataTable bookList = new DataTable();
            SqlCommand cmd = new SqlCommand("Sach_LayDanhMucSach", db.GetConnection());
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
            adapter.Fill(bookList);

            return bookList;
        }

        /// <summary>
        /// Thêm sách vào CSDL sử dụng sp "Sach_CapNhatThongTin"
        /// </summary>
        /// <param name="TenSach">Tên sách cần thêm</param>
        /// <param name="TacGia">Tác giả sách</param>
        /// <param name="LoaiSach">Loại sách (ví dụ như Sách văn học...)</param>
        /// <param name="SoLuong">Số lượng cần thêm</param>
        public void addBook(string TenSach, string TacGia, string LoaiSach, int SoLuong)
        {
            SqlCommand cmd = new SqlCommand("Sach_CapNhatThongTin", db.GetConnection());

            cmd.Parameters.AddWithValue("@IDSach", 0);
            cmd.Parameters.AddWithValue("@TenSach", TenSach);
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            cmd.Parameters.AddWithValue("@LoaiSach", LoaiSach);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Sửa thông tin sách sử dụng sp "Sach_CapNhatThongTin"
        /// </summary>
        /// <param name="IDSach">Mã sách cần sửa</param>
        /// <param name="TenSach">Tên sách mới</param>
        /// <param name="TacGia">Tác giả sách mới</param>
        /// <param name="LoaiSach">Loại sách mới</param>
        /// <param name="SoLuong">Số lượng mới</param>
        public void editBook(int IDSach, string TenSach, string TacGia, string LoaiSach, int SoLuong)
        {
            SqlCommand cmd = new SqlCommand("Sach_CapNhatThongTin", db.GetConnection());

            cmd.Parameters.AddWithValue("@IDSach", IDSach);
            cmd.Parameters.AddWithValue("@TenSach", TenSach);
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            cmd.Parameters.AddWithValue("@LoaiSach", LoaiSach);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Xóa sách theo IDSach đã chọn, lấy từ bảng danh mục, dùng sp "Sach_XoaSach"
        /// </summary>
        /// <param name="IDSach">Mã sách cần xóa</param>
        public void deleteBook (int IDSach)
        {
            SqlCommand cmd = new SqlCommand("Sach_XoaSach", db.GetConnection());

            cmd.Parameters.AddWithValue("@IDSach", IDSach);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
    }
}
