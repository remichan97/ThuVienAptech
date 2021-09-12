using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class Data
    {
        public string conn { get; set; }

        public Data()
        {
            this.conn = ConfigurationManager.ConnectionStrings["KetNoi"].ConnectionString;
        }
    }
}
