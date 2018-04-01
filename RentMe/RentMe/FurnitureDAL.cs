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
    class FurnitureDAL
    {
        public static Furniture GetFurniture(int furnitureID)
        {
            Furniture furniture = new Furniture();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT furnitureID, description, styleID, categoryID, fine_Rate, daily_Rate " +
                "FROM furniture " +
                "WHERE furnitureID = @furnitureID";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@furnitureID", furnitureID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    furniture.furnitureID = Convert.ToInt32(reader["furnitureID"].ToString());
                    furniture.description = reader["description"].ToString();
                    furniture.styleID = Convert.ToInt32(reader["furnitureID"].ToString());
                    furniture.categoryID = Convert.ToInt32(reader["categoryID"].ToString());
                    furniture.fine_Rate = Convert.ToDecimal(reader["fine_Rate"].ToString());
                    furniture.daily_Rate = Convert.ToDecimal(reader["daily_Rate"].ToString());


                }
                else
                {
                    furniture = null;
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
            return furniture;
        }
    }
}
