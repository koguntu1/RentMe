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
        public static List<Furniture> GetFurniture(int furnitureID, int itemID, string category, string style)
        {
            List<Furniture> furnitureList = new List<Furniture>();
            string selectStatement =
                "SELECT f.furnitureID, f.description, c.description as category, s.description as style, f.fine_Rate, f.daily_Rate " +
                "FROM dbo.furniture f INNER JOIN dbo.store_item i" +
                "ON f.furnitureID = i.furnitureID INNER JOIN" +
                "dbo.style s" +
                "ON f.styleID = s.styleID INNER JOIN" +
                "dbo.category c" +
                "ON f.categoryID = c.categoryID " +
                "WHERE ";
            if (furnitureID != 0)
            {
                selectStatement = selectStatement + "f.furnitureID = " + furnitureID + " OR ";
            }

            if (itemID != 0)
            {
                selectStatement = selectStatement + "i.itemID = " + itemID + " OR ";
            }

            if (!category.Equals(""))
            {
                selectStatement = selectStatement + "c.description LIKE " + category + " OR ";
            }

            if (!style.Equals(""))
            {
                selectStatement = selectStatement + "s.description LIKE " + category;
            }


            try
            {
                using (SqlConnection connection = RentMeDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Furniture furniture = new Furniture();
                                furniture.furnitureID = Convert.ToInt32(reader["furnitureID"].ToString());
                                furniture.description = reader["description"].ToString();
                                furniture.style = reader["style"].ToString();
                                furniture.category = reader["category"].ToString();
                                furniture.itemID = Convert.ToInt32(reader["itemID"].ToString());
                                furniture.fine_Rate = Convert.ToDecimal(reader["fine_Rate"].ToString());
                                furniture.daily_Rate = Convert.ToDecimal(reader["daily_Rate"].ToString());
                                furnitureList.Add(furniture);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return furnitureList;
        }
    }
}
