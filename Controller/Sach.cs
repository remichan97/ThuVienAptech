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
    }
}
