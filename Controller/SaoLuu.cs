using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.Controller
{
    public class SaoLuu
    {
        Database db = new Database();
        public void saoLuuDuLieu (string duongdan)
        {
            SqlCommand cmd = new SqlCommand("backup database QuanLyThuVien to disk = @duongdan", db.GetConnection());

            cmd.Parameters.AddWithValue("@duongdan", duongdan + "\\ThuVien.bak");

            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
    }
}
