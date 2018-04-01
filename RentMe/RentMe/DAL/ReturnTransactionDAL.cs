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
    class ReturnTransactionDAL
    {
        public static ReturnTransaction GetReturnTransaction(int returnTransactionID)
        {
            ReturnTransaction returnTransaction = new ReturnTransaction();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT returnTransactionID, date, amount, comment, rentalItemID, fines, return_date, employeeID " +
                "FROM returnTransaction " +
                "WHERE returnTransactionID = @returnTransactionID";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@returnTransactionID", returnTransactionID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    returnTransaction.returnTransactionID = Convert.ToInt32(reader["returnTransactionID"].ToString());
                    returnTransaction.date = (DateTime)reader["date"];
                    returnTransaction.amount = reader["amount"].ToString();
                    returnTransaction.comment = reader["comment"].ToString();
                    returnTransaction.rentalItemID = Convert.ToInt32(reader["rentalItemID"].ToString());
                    returnTransaction.fines = Convert.ToDecimal(reader["fines"].ToString());
                    returnTransaction.return_date = (DateTime)reader["return_date"];
                    returnTransaction.employeeID = Convert.ToInt32(reader["employeeID"].ToString());

                }
                else
                {
                    returnTransaction = null;
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
            return returnTransaction;
        }
    }
}
