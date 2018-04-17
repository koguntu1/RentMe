using RentMe.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.DAL
{
    class RentalTransactionIDDAL
    {
        public static int AddRentalTransactionID(RentalTransactionID rentalTransactionID)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string insertStatement =
                "INSERT Rental_transaction " +
                  "(rentalID, transactionID) " +
                "VALUES (@rentalID, @transactionID)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@rentalID", rentalTransactionID.rentalID);
            insertCommand.Parameters.AddWithValue("@transactionID", rentalTransactionID.transactionID);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Rental_transaction') FROM Rental_transaction";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int transactionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return transactionID;
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
