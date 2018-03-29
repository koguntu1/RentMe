using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace furniture
{
    class DBconnection
    {
        public static SqlConnection NewCon;
        public static string ConStr = ConfigurationManager.ConnectionStrings["furniture.Properties.Settings.RentMeConnectionString"].ConnectionString;
        public static SqlConnection GetConnection() {

            NewCon = new SqlConnection(ConStr);
            return NewCon;
        }


    }
}
