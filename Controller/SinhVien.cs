using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.Controller
{
	public class SinhVien
	{
		private Database db = new Database();

		/// <summary>
		/// Lấy toàn bộ danh sách sinh viên, hoặc lấy danh sách sinh viên theo tên sinh viên dùng sp SinhVien_LayDanhSachSinhVien
		/// </summary>
		/// <param name="timkiem">Từ khóa tìm kiếm</param>
		/// <returns>Trả về toàn bộ, hoặc tên những sinh viên theo từ khóa tìm kiếm</returns>
		public DataTable GetStudentList(string timkiem)
		{
			DataTable stdList = new DataTable();

			SqlCommand cmd = new SqlCommand("SinhVien_LayDanhSachSinhVien", db.GetConnection());

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
			adapter.Fill(stdList);

			return stdList;
		}

        /// <summary>
        /// Lấy các tùy chọn giới tính
        /// </summary>
        /// <returns>Các tùy chọn giới tính (Nam/Nữ), cũng như giá trị thực tế khi đưa vào CSDL</returns>
		public DataTable GetGenderOptions()
		{
			DataTable gdList = new DataTable();

			SqlCommand cmd = new SqlCommand("select distinct GioiTinh, case when GioiTinh = 0 then N'Nam' else N'Nữ' end as GioiTinhDich from SinhVien", db.GetConnection());

			cmd.CommandType = CommandType.Text;

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(gdList);

			return gdList;
		}

        /// <summary>
        /// Thêm thông tin sinh viên vào CSDL
        /// </summary>
        /// <param name="MaSV">Mã sinh viên</param>
        /// <param name="TenSinhVien">Tên sinh viên</param>
        /// <param name="DiaChi">Địa chỉ</param>
        /// <param name="GioiTinh">Giới tính (Nam/Nữ) (0/1)</param>
        public void addStudent(string MaSV, string TenSinhVien, string DiaChi, int GioiTinh)
        {
            SqlCommand cmd = new SqlCommand("SinhVien_CapNhatThongTin", db.GetConnection());

            cmd.Parameters.AddWithValue("@MaSV", MaSV);
            cmd.Parameters.AddWithValue("@TenSinhVien", TenSinhVien);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@Option", 1);
            cmd.Parameters.AddWithValue("@MaSVCu", "");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        public void editStudent(string MaSVCu, string MaSV, string TenSinhVien, string DiaChi, int GioiTinh)
        {
            SqlCommand cmd = new SqlCommand("SinhVien_CapNhatThongTin", db.GetConnection());

            cmd.Parameters.AddWithValue("@MaSV", MaSV);
            cmd.Parameters.AddWithValue("@TenSinhVien", TenSinhVien);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@Option", 2);
            cmd.Parameters.AddWithValue("@MaSVCu", MaSVCu);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        public void deleteStudent(string MaSV)
        {
            SqlCommand cmd = new SqlCommand("SinhVien_CapNhatThongTin", db.GetConnection());

            cmd.Parameters.AddWithValue("@MaSV", MaSV);
            cmd.Parameters.AddWithValue("@TenSinhVien", "");
            cmd.Parameters.AddWithValue("@DiaChi", "");
            cmd.Parameters.AddWithValue("@GioiTinh", "");
            cmd.Parameters.AddWithValue("@Option", 3);
            cmd.Parameters.AddWithValue("@MaSVCu", "");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
	}
}
