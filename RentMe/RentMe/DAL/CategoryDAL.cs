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
    class CategoryDAL
    {
        public static List<Category> GetCategoryList()
        {
            List<Category> categoryList = new List<Category>();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectStatement =
                "SELECT * FROM Category ORDER BY categoryID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Category category = new Category();
                    category.categoryID = (int)reader["categoryID"];
                    category.description = reader["description"].ToString();
                    categoryList.Add(category);
                }
                //add an empty Category
                Category styleEmpty = new Category();
                styleEmpty.categoryID = -1;
                styleEmpty.description = "";
                categoryList.Add(styleEmpty);
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
            return categoryList;
        }

        public static Category GetCategory(int categoryID)
        {
            Category category = new Category();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT categoryID, description " +
                "FROM category " +
                "WHERE categoryID = @categoryID";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@categoryID", categoryID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    category.categoryID = Convert.ToInt32(reader["categoryID"].ToString());
                    category.description = reader["description"].ToString();

                }
                else
                {
                    category = null;
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
            return category;
        }
    }
}
