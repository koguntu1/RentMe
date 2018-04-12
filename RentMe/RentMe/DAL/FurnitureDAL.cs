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
        public static List<Furniture> GetFurnitureList()
        {
            List<Furniture> furnitureList = new List<Furniture>();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectStatement =
                "SELECT * FROM Furniture ORDER BY furnitureID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Furniture furniture = new Furniture();
                    furniture.FurnitureID = (int)reader["furnitureID"];
                    furniture.Description = reader["description"].ToString();
                    furnitureList.Add(furniture);
                }
                //add an empty Category
                Furniture furnitureEmpty = new Furniture();
                furnitureEmpty.FurnitureID = -1;
                furnitureEmpty.Description = "";
                furnitureList.Add(furnitureEmpty);
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
            return furnitureList;
        }

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


        public static int AddFurniture(Furniture furniture)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string insertStatement =
                "INSERT Furniture " +
                  "(description, styleID, categoryID, fine_Rate, daily_Rate) " +
                "VALUES (@description, @styleID, @categoryID, @fine_Rate, @daily_Rate)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@description", furniture.Description);
            insertCommand.Parameters.AddWithValue("@styleID", furniture.StyleID);
            insertCommand.Parameters.AddWithValue("@categoryID", furniture.CategoryID);
            insertCommand.Parameters.AddWithValue("@fine_Rate", furniture.Fine_Rate);
            insertCommand.Parameters.AddWithValue("@daily_Rate", furniture.Daily_Rate);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Furniture') FROM Furniture";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int funitureID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return funitureID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateFurniture(Furniture oldFurniture, Furniture newFurniture)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string updateStatement =
                "UPDATE Furniture SET " +
                  "description = @NewDescription, " +
                  "styleID = @NewStyleID, " +
                  "categoryID = @NewCategoryID, " +
                  "fine_Rate = @Newfine_Rate, " +
                  "daily_Rate = @Newdaily_Rate " +
                "WHERE furnitureID = @OldfurnitureID " +
                "AND description = @Olddescription AND styleID = @OldstyleID AND categoryID = @OldcategoryID " +
                "AND fine_Rate = @Oldfine_Rate AND daily_Rate = @Olddaily_Rate";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewDescription", newFurniture.Description);
            updateCommand.Parameters.AddWithValue("@NewStyleID", newFurniture.StyleID);
            updateCommand.Parameters.AddWithValue("@NewCategoryID", newFurniture.CategoryID);
            updateCommand.Parameters.AddWithValue("@Newfine_Rate", newFurniture.Fine_Rate);
            updateCommand.Parameters.AddWithValue("@Newdaily_Rate", newFurniture.Daily_Rate);
            
            updateCommand.Parameters.AddWithValue("@OldfurnitureID", oldFurniture.FurnitureID);
            updateCommand.Parameters.AddWithValue("@Olddescription", oldFurniture.Description);
            updateCommand.Parameters.AddWithValue("@OldstyleID", oldFurniture.StyleID);
            updateCommand.Parameters.AddWithValue("@OldcategoryID", oldFurniture.CategoryID);
            updateCommand.Parameters.AddWithValue("@Oldfine_Rate", oldFurniture.Fine_Rate);
            updateCommand.Parameters.AddWithValue("@Olddaily_Rate", oldFurniture.Daily_Rate);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
