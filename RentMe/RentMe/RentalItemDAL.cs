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
    class RentalItemDAL
    {
        public static RentalItem GetRentalItem(int rentalItemID)
        {
            RentalItem rentalItem = new RentalItem();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT rentalItemID, rentalTransactionID, itemID, quantity " +
                "FROM rentalItem " +
                "WHERE rentalItemID = @rentalItemID";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@rentalItemID", rentalItemID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    rentalItem.rentalItemID = Convert.ToInt32(reader["rentalItemID"].ToString());
                    rentalItem.rentalTransactionID = Convert.ToInt32(reader["rentalTransactionID"].ToString());
                    rentalItem.itemID = Convert.ToInt32(reader["itemID"].ToString());
                    rentalItem.quantity = Convert.ToInt32(reader["quantity"].ToString());

                }
                else
                {
                    rentalItem = null;
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
            return rentalItem;
        }
    }
}
