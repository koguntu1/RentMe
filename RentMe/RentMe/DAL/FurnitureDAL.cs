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
        public static List<Furniture> GetFurniture(int furnitureID, int itemID, int categoryID, int styleID)
        {
            List<Furniture> furnitureList = new List<Furniture>();
            string selectStatement =
                "SELECT f.furnitureID, f.styleID, f.description, i.itemID, c.description as category, s.description as style, f.fine_Rate, f.categoryID, f.daily_Rate " +
                "FROM dbo.furniture f INNER JOIN dbo.store_item i " +
                "ON f.furnitureID = i.furnitureID INNER JOIN " +
                "dbo.style s " +
                "ON f.styleID = s.styleID INNER JOIN " +
                "dbo.category c " +
                "ON f.categoryID = c.categoryID " +
                "WHERE (";
            if (furnitureID != 0)
            {
                selectStatement = selectStatement + "f.furnitureID = @furnitureID";
            }

            if (itemID != 0 && furnitureID == 0)
            {
                selectStatement = selectStatement + "i.itemID = @itemID";
            }
            else if (itemID != 0 && furnitureID != 0)
            {
                selectStatement = selectStatement + " OR i.itemID = @itemID";
            }

            if (categoryID != 0 && furnitureID == 0 && itemID == 0)
            {
                selectStatement = selectStatement + "c.categoryID = @categoryID";
            }
            else if (categoryID != 0 && (furnitureID != 0 || itemID != 0))
            {
                selectStatement = selectStatement + " OR c.categoryID = @categoryID";
            }

            if (styleID != 0 && furnitureID == 0 && itemID == 0 && categoryID == 0)
            {
                selectStatement = selectStatement + "s.styleID = @styleID";
            }
            else if (styleID != 0 && (furnitureID != 0 || itemID != 0 || categoryID != 0))
            {
                selectStatement = selectStatement + " OR s.styleID = @styleID";
            }

            selectStatement = selectStatement + ")";

            SqlConnection connection = RentMeDBConnection.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            if (furnitureID != 0)
            {
                selectCommand.Parameters.AddWithValue("@furnitureID", furnitureID);
            }

            if (itemID != 0 && furnitureID == 0)
            {
                selectCommand.Parameters.AddWithValue("@itemID", itemID);
            }
            else if (itemID != 0 && furnitureID != 0)
            {
                selectCommand.Parameters.AddWithValue("@itemID", itemID);
            }

            if (categoryID != 0 && furnitureID == 0 && itemID == 0)
            {
                selectCommand.Parameters.AddWithValue("@categoryID", categoryID);
            }
            else if (categoryID != 0 && (furnitureID != 0 || itemID != 0))
            {
                selectCommand.Parameters.AddWithValue("@categoryID", categoryID);
            }

            if (styleID != 0 && furnitureID == 0 && itemID == 0 && categoryID == 0)
            {
                selectCommand.Parameters.AddWithValue("@styleID", styleID);
            }
            else if (styleID != 0 && (furnitureID != 0 || itemID != 0 || categoryID != 0))
            {
                selectCommand.Parameters.AddWithValue("@styleID", styleID);
            }
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Furniture furniture = new Furniture();
                    furniture.FurnitureID = Convert.ToInt32(reader["furnitureID"].ToString());
                    furniture.Description = reader["description"].ToString();
                    furniture.Style = reader["style"].ToString();
                    furniture.Category = reader["category"].ToString();
                    furniture.ItemID = Convert.ToInt32(reader["itemID"].ToString());
                    furniture.Fine_Rate = Convert.ToDecimal(reader["fine_Rate"].ToString());
                    furniture.Daily_Rate = Convert.ToDecimal(reader["daily_Rate"].ToString());
                    furniture.CategoryID = Convert.ToInt32(reader["categoryID"].ToString());
                    furniture.StyleID = Convert.ToInt32(reader["styleID"].ToString());
                    furnitureList.Add(furniture);
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

            //try
            //{
            //    using (SqlConnection connection = RentMeDBConnection.GetConnection())
            //    {
            //        connection.Open();

            //        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
            //        {

            //            using (SqlDataReader reader = selectCommand.ExecuteReader())
            //            {
            //                while (reader.Read())
            //                {
            //                    Furniture furniture = new Furniture();
            //                    furniture.furnitureID = Convert.ToInt32(reader["furnitureID"].ToString());
            //                    furniture.description = reader["description"].ToString();
            //                    furniture.style = reader["style"].ToString();
            //                    furniture.category = reader["category"].ToString();
            //                    furniture.itemID = Convert.ToInt32(reader["itemID"].ToString());
            //                    furniture.fine_Rate = Convert.ToDecimal(reader["fine_Rate"].ToString());
            //                    furniture.daily_Rate = Convert.ToDecimal(reader["daily_Rate"].ToString());
            //                    furnitureList.Add(furniture);
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    throw ex;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return furnitureList;
        }
    }
}
