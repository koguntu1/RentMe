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
                "SELECT transactionID, date, amount, comment, employeeID, fines " +
                "FROM rentalTransaction " +
                "WHERE transactionID = @transactionID";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@transactionID", rentalTransactionID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    rentalTransaction.rentalTransactionID = Convert.ToInt32(reader["transactionID"].ToString());
                    rentalTransaction.transactionDate = Convert.ToDateTime(reader["memberID"].ToString());
                    rentalTransaction.amount = Convert.ToDouble(reader["expected_return"]);
                    rentalTransaction.comment = reader["rental_date"].ToString();
                    rentalTransaction.employeeID = Convert.ToInt32(reader["employeeID"].ToString());
                    rentalTransaction.fines = Convert.ToDouble(reader["fines"]);

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

        public static int AddRentalTransaction(RentalTransaction rentalTransaction)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string insertStatement =
                "INSERT Transactions " +
                  "(date, amount, comment, employeeID, fines) " +
                "VALUES (@date, @amount, @comment, @employeeID, @fines)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@date", rentalTransaction.transactionDate);
            insertCommand.Parameters.AddWithValue("@amount", rentalTransaction.amount);
            if (string.IsNullOrEmpty(rentalTransaction.comment))
            {
                insertCommand.Parameters.AddWithValue("@comment", "");
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@comment", rentalTransaction.comment);
            }
            insertCommand.Parameters.AddWithValue("@employeeID", rentalTransaction.employeeID);
            if (rentalTransaction.fines == null)
            {
                insertCommand.Parameters.AddWithValue("@fines", 0.00);
            }
            else
            {

                insertCommand.Parameters.AddWithValue("@fines", rentalTransaction.fines);
            }
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Transactions') FROM Transactions";
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