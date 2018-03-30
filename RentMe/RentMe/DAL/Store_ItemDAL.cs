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
    class Store_ItemDAL
    {
        public static Store_item GetStore_item(int itemID)
        {
            Store_item store_item = new Store_item();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT itemID, furnitureID " +
                "FROM store_item " +
                "WHERE itemID = @itemID";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@itemID", itemID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    store_item.itemID = Convert.ToInt32(reader["itemID"].ToString());
                    store_item.furnitureID = Convert.ToInt32(reader["furnitureID"].ToString());

                }
                else
                {
                    store_item = null;
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
            return store_item;
        }
    }
}
