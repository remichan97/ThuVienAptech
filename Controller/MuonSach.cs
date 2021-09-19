using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.Controller
{
    public class MuonSach
    {
        Database db = new Database();

        /// <summary>
        /// Lấy toàn bộ/hoặc theo từ khóa danh sách sinh viên mượn sách
        /// </summary>
        /// <param name="timkiem">Từ khóa tìm kiếm sinh viên</param>
        /// <returns>Trả về toàn bộ, hoặc theo từ khóa tìm kiếm</returns>
        public DataTable GetDanhMucMuonSach(string timkiem)
        {
            DataTable borrowerList = new DataTable();

            SqlCommand cmd = new SqlCommand("MuonSach_LayDanhMucMuonSach", db.GetConnection());

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

            adapter.Fill(borrowerList);

            return borrowerList;
        }

        /// <summary>
        /// Thêm thông tin mượn sách
        /// </summary>
        /// <param name="IDSinhVien">Mã sinh viên</param>
        /// <param name="ngayMuon">Ngày mượn</param>
        /// <param name="ngayTra">Ngày trả</param>
        /// <param name="GhiChu">Ghi chú</param>
        /// <param name="ChiTietSachMuon">Danh sách đầu sách mượn của sinh viên</param>
        public void muonSach(string IDSinhVien, string ngayMuon, string ngayTra, string GhiChu, Dictionary<int, int> ChiTietSachMuon)
        {
            int tong = 0;

            for (int i = 0; i < ChiTietSachMuon.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("Sach_KiemTraSoLuong", db.GetConnection());

                cmd.Parameters.AddWithValue("@IDSach", ChiTietSachMuon.ElementAt(i).Key);
                cmd.Parameters.AddWithValue("@SoLuong", ChiTietSachMuon.ElementAt(i).Value);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }

            for (int i = 0; i < ChiTietSachMuon.Count; i++)
            {
                tong += Convert.ToInt32(ChiTietSachMuon.ElementAt(i).Value);
            }

            SqlCommand cmd1 = new SqlCommand("insert MuonSach values (@idsinhvien, @ngaymuon, @ngaytra, @sl, @ghichu)", db.GetConnection());

            cmd1.Parameters.AddWithValue("@idsinhvien", IDSinhVien);
            cmd1.Parameters.AddWithValue("@ngaymuon", ngayMuon);
            cmd1.Parameters.AddWithValue("@ngaytra", ngayTra);
            cmd1.Parameters.AddWithValue("@sl", tong);
            cmd1.Parameters.AddWithValue("@ghichu", GhiChu);

            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();

            
            for (int i = 0; i < ChiTietSachMuon.Count; i++)
            {
                SqlCommand cmd2 = new SqlCommand("MuonSach_CapNhatMuonSachChiTiet", db.GetConnection());
                cmd2.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                cmd2.Parameters.AddWithValue("@NgayTra", ngayTra);
                cmd2.Parameters.AddWithValue("@IDNguoiMuon", IDSinhVien);
                cmd2.Parameters.AddWithValue("@IDSach", ChiTietSachMuon.ElementAt(i).Key);
                cmd2.Parameters.AddWithValue("@SoLuong", ChiTietSachMuon.ElementAt(i).Value);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.ExecuteNonQuery();
            }
        }
    }
}
