﻿using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.Controller
{
	public class TraSach
	{
		Database db = new Database();
		public DataTable timKiemThongTinNguoiMuon(string timkiem, string NgayMuon, string NgayTra)
		{
			DataTable borrow = new DataTable();

			SqlCommand cmd = null;

			if (string.IsNullOrEmpty(timkiem) && string.IsNullOrEmpty(NgayMuon) && string.IsNullOrEmpty(NgayTra))
			{
				cmd = new SqlCommand("select NgayMuon, NgayTra, TenSinhVien, TenSach, SoLuongMuon, a.IDSach from MuonSach_ChiTiet a join SinhVien b on a.IDNguoiMuon = b.MaSinhVien join Sach c on a.IDSach = c.IDSach where IDNguoiMuon = '' and NgayMuon = '' and NgayTra = ''", db.GetConnection());
			}
			else
			{
				cmd = new SqlCommand("select NgayMuon, NgayTra, TenSinhVien, TenSach, SoLuongMuon, a.IDSach from MuonSach_ChiTiet a join SinhVien b on a.IDNguoiMuon = b.MaSinhVien join Sach c on a.IDSach = c.IDSach where IDNguoiMuon = @idnguoimuon and NgayMuon = @ngaymuon and NgayTra = @ngaytra", db.GetConnection());
				cmd.Parameters.AddWithValue("@idnguoimuon", timkiem);
				cmd.Parameters.AddWithValue("@ngaymuon", NgayMuon);
				cmd.Parameters.AddWithValue("@ngaytra", NgayTra);
			}

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(borrow);

			return borrow;
		}

		public void traSach(string TenNguoiMuon, string NgayMuon, string NgayTra, Dictionary<int, int> borrow, int option) 
		{
			for (int i = 0; i < borrow.Count; i++)
			{
				SqlCommand cmd = new SqlCommand("TraSach", db.GetConnection());

				cmd.Parameters.AddWithValue("@MaSinhVien", TenNguoiMuon);
				cmd.Parameters.AddWithValue("@NgayMuon", NgayMuon);
				cmd.Parameters.AddWithValue("@NgayTra", NgayTra);
				cmd.Parameters.AddWithValue("@MaSach", borrow.ElementAt(i).Key);
				cmd.Parameters.AddWithValue("@SoLuong", borrow.ElementAt(i).Value);
				cmd.Parameters.AddWithValue("@option", option);

				cmd.CommandType = CommandType.StoredProcedure;
				cmd.ExecuteNonQuery();
			}
		}

		public void baoMatSach(Dictionary<int, int> lostBook, string NgayMat, string MaSinhVien, string NgayMuon, string NgayTra)
		{
			for (int i = 0; i < lostBook.Count; i++)
			{
				SqlCommand cmd = new SqlCommand("TraSach_BaoMatSach", db.GetConnection());

				cmd.Parameters.AddWithValue("@NgayMat", NgayMat);
				cmd.Parameters.AddWithValue("@MaSinhVien", MaSinhVien);
				cmd.Parameters.AddWithValue("@IDSachMat", lostBook.ElementAt(i).Key);
				cmd.Parameters.AddWithValue("@SoLuongMat", lostBook.ElementAt(i).Value);
				cmd.Parameters.AddWithValue("@NgayMuon", NgayMuon);
				cmd.Parameters.AddWithValue("@NgayTra", NgayTra);

				cmd.ExecuteNonQuery();
			}
		}
	}
}
