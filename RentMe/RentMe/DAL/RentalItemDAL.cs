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


        public static DataSet GetRentHistory(int employeeID, int memberID, DateTime fromDate, DateTime toDate)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectStatement =
                "SELECT Employee.fname as 'employee firstname', Employee.lname as 'employee lastname', Member.fname as 'customer firstname', Member.lname as 'customer lastname', " +
                "Rental.rentalID, Rental.itemID, Rental.rental_date, Rental.return_date, Rental.expected_return as 'due date', Store_item.furnitureID, Furniture.description, Rental_transaction.transactionID, " +
                "Transactions.amount, Transactions.fines " +
                "from Rental, Member, Store_item, Furniture, Rental_transaction, Transactions, Employee where " +
                "(Rental.memberID = Member.memberID and Rental.itemID = Store_item.itemID and " +
                "Store_item.furnitureID = Furniture.furnitureID and Rental.rentalID = Rental_transaction.rentalID " +
                "and Rental_transaction.transactionID = Transactions.transactionID and Transactions.employeeID = Employee.employeeID  ";

            if (employeeID > 0)
            {
                if (memberID > 0)
                {
                    selectStatement = selectStatement + " and Employee.employeeID = @employeeID and Member.memberID = @memberID" +
                        " and (Rental.rental_date between @fromDate and @toDate))";
                }
                else
                {
                    selectStatement = selectStatement + " and Employee.employeeID" +
                        " and (Rental.rental_date between @fromDate and @toDate))";
                }
            }
            else if (employeeID < 0 && memberID > 0)
            {
                selectStatement = selectStatement + " and Member.memberID = @memberID" +
                        " and (Rental.rental_date between @fromDate and @toDate))";
            }

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@fromDate", fromDate);
            selectCommand.Parameters.AddWithValue("@toDate", toDate);
            if (memberID > 0)
            {
                selectCommand.Parameters.AddWithValue("@memberID", memberID);
            }

            if (employeeID > 0)
            {
                selectCommand.Parameters.AddWithValue("@employeeID", employeeID);
            }

            //dataAdapter.SelectCommand = selectCommand;
            // Populate a new data table
            DataSet dataSet = new DataSet();
            try
            {
                connection.Open();
                SqlDataReader sdr = selectCommand.ExecuteReader();
                dataSet.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataSet.Tables.Add("RentalHistory");

                //Load DataReader into the DataTable.
                dataSet.Tables[0].Load(sdr);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dataSet;
        }


        public static DataSet GetReturnHistory(int employeeID, int memberID, DateTime fromDate, DateTime toDate)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectStatement =
                "SELECT Employee.fname as 'employee firstname', Employee.lname as 'employee lastname', Member.fname as 'customer firstname', Member.lname as 'customer lastname', " +
                "Rental.rentalID, Rental.itemID, Rental.rental_date, Rental.return_date, Rental.expected_return as 'due date', Store_item.furnitureID, Furniture.description, Rental_return_transaction.transactionID, " +
                "Transactions.amount, Transactions.fines " +
                "from Rental, Member, Store_item, Furniture, Rental_return_transaction, Transactions, Employee where " +
                "(Rental.memberID = Member.memberID and Rental.itemID = Store_item.itemID and " +
                "Store_item.furnitureID = Furniture.furnitureID and Rental.rentalID = Rental_return_transaction.rentalID " +
                "and Rental_return_transaction.transactionID = Transactions.transactionID and Transactions.employeeID = Employee.employeeID  ";

            if (employeeID > 0)
            {
                if (memberID > 0)
                {
                    selectStatement = selectStatement + " and Employee.employeeID = @employeeID and Member.memberID = @memberID" +
                        " and (Rental.rental_date between @fromDate and @toDate) and (Rental.return_date is not null))";
                }
                else
                {
                    selectStatement = selectStatement + " and Employee.employeeID" +
                        " and (Rental.rental_date between @fromDate and @toDate) and (Rental.return_date is not null))";
                }
            }
            else if (employeeID < 0 && memberID > 0)
            {
                selectStatement = selectStatement + " and Member.memberID = @memberID" +
                        " and (Rental.rental_date between @fromDate and @toDate) and (Rental.return_date is not null))";
            }

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@fromDate", fromDate);
            selectCommand.Parameters.AddWithValue("@toDate", toDate);
            if (memberID > 0)
            {
                selectCommand.Parameters.AddWithValue("@memberID", memberID);
            }

            if (employeeID > 0)
            {
                selectCommand.Parameters.AddWithValue("@employeeID", employeeID);
            }

            //dataAdapter.SelectCommand = selectCommand;
            // Populate a new data table
            DataSet dataSet = new DataSet();
            try
            {
                connection.Open();
                SqlDataReader sdr = selectCommand.ExecuteReader();
                dataSet.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataSet.Tables.Add("ReturnHistory");

                //Load DataReader into the DataTable.
                dataSet.Tables[0].Load(sdr);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dataSet;
        }
        public static int AddRentalItem(RentalItem rentalItem)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string insertStatement =
                "INSERT Rental " +
                  "(memberID, expected_return, itemID, rental_date) " +
                "VALUES (@memberID, @expected_return, @itemID, @rental_date)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@memberID", rentalItem.memberID);
            insertCommand.Parameters.AddWithValue("@expected_return", rentalItem.expectedReturn);
            insertCommand.Parameters.AddWithValue("@itemID", rentalItem.itemID);
            //insertCommand.Parameters.AddWithValue("@return_date", rentalItem.returnDate);
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
