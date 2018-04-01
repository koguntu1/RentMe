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
    class RentalTransactionDAL
    {
        public static RentalTransaction GetRentalItem(int rentalTransactionID)
        {
            RentalTransaction rentalTransaction = new RentalTransaction();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT rentalTransactionID, memberID, expected_return, rental_date, employeeID " +
                "FROM rentalTransaction " +
                "WHERE rentalTransactionID = @rentalTransactionID";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@rentalTransactionID", rentalTransactionID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    rentalTransaction.rentalTransactionID = Convert.ToInt32(reader["rentalTransactionID"].ToString());
                    rentalTransaction.memberID = Convert.ToInt32(reader["memberID"].ToString());
                    rentalTransaction.expected_return = (DateTime)reader["expected_return"];
                    rentalTransaction.rental_date = (DateTime)reader["rental_date"];
                    rentalTransaction.employeeID = Convert.ToInt32(reader["employeeID"].ToString());

                }
                else
                {
                    rentalTransaction = null;
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
            return rentalTransaction;
        }
    }
}
