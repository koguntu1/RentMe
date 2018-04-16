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
                "SELECT rentalItemID, memberID, expected_return, itemID, return_date, rental_date " +
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
                    rentalItem.memberID = Convert.ToInt32(reader["memberID"].ToString());
                    rentalItem.expectedReturn = Convert.ToDateTime(reader["expected_return"].ToString());
                    rentalItem.itemID = Convert.ToInt32(reader["itemID"].ToString());
                    rentalItem.returnDate = Convert.ToDateTime(reader["return_date"].ToString());
                    rentalItem.rentalDate = Convert.ToDateTime(reader["rental_date"].ToString());

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

        public static int AddRentalItem(RentalItem rentalItem)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string insertStatement =
                "INSERT Rental " +
                  "(memberID, expected_return, itemID, return_date, rental_date) " +
                "VALUES (@memberID, @expected_return, @itemID, @return_date, @rental_date)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@memberID", rentalItem.memberID);
            insertCommand.Parameters.AddWithValue("@expected_return", rentalItem.expectedReturn);
            insertCommand.Parameters.AddWithValue("@itemID", rentalItem.itemID);
            insertCommand.Parameters.AddWithValue("@return_date", rentalItem.returnDate);
            insertCommand.Parameters.AddWithValue("@rental_date", rentalItem.rentalDate);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Rental') FROM Rental";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int rentalID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return rentalID;
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
