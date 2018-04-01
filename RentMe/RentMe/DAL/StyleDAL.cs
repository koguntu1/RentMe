using RentMe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.DAL
{
    class StyleDAL
    {
        public static Style GetStyle(int styleID)
        {
            Style style = new Style();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT styleID, description " +
                "FROM style " +
                "WHERE styleID = @styleID";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@styleID", styleID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    style.styleID = Convert.ToInt32(reader["styleID"].ToString());
                    style.description = reader["description"].ToString();

                }
                else
                {
                    style = null;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return style;
        }
    }
}
