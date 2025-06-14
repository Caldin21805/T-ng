using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace QLBH
{
    internal class Connecttion
    {
        private static string stringConnection = @"Server=DESKTOP-CR690E6;Database=QLBanHang;Trusted_Connection=True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
