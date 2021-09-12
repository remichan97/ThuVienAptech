using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class Database
    {
        Data dt = new Data();

        public SqlConnection GetConnection()
        {
            SqlConnection sql = new SqlConnection(dt.conn);
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }

            return sql;
        }
    }
}
