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
        public static List<ReturnTransaction> GetRentedFurniture(int memberID)
        {
            List<ReturnTransaction> listReturnTransaction = new List<ReturnTransaction>();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT m.fname, m.lname, f.furnitureID, i.itemID, f.description, s.description AS Style, " +
                "c.description AS Category, r.rental_date, r.expected_return, t.amount, r.rentalID, t.transactionID, f.daily_Rate, f.fine_Rate, m.memberID " +
                "FROM Rental AS r INNER JOIN " +
                "Rental_transaction AS rt ON r.rentalID = rt.rentalID INNER JOIN " +
                "Transactions AS t ON t.transactionID = rt.transactionID INNER JOIN " +
                "Member AS m ON m.memberID = r.memberID INNER JOIN " +
                "Store_item AS i ON i.itemID = r.itemID INNER JOIN " +
                "Furniture AS f ON f.furnitureID = i.furnitureID INNER JOIN " +
                "Style AS s ON s.styleID = f.furnitureID INNER JOIN " +
                "Category AS c ON c.categoryID = f.categoryID " +
            "WHERE m.memberID = @memberID and r.return_date is NULL";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@memberID", memberID);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    ReturnTransaction returnTransaction = new ReturnTransaction();
                    returnTransaction.fname = reader["fname"].ToString();
                    returnTransaction.lname = reader["lname"].ToString();
                    returnTransaction.furnitureID = Convert.ToInt32(reader["furnitureID"].ToString());
                    returnTransaction.itemID = Convert.ToInt32(reader["itemID"].ToString());
                    returnTransaction.description = reader["description"].ToString();
                    returnTransaction.style = reader["Style"].ToString();
                    returnTransaction.category = reader["Category"].ToString();
                    returnTransaction.rental_date = (DateTime)reader["rental_date"];
                    returnTransaction.expected_return = (DateTime)reader["expected_return"];
                    returnTransaction.amount = Convert.ToDecimal(reader["amount"].ToString());
                    returnTransaction.rentalID = Convert.ToInt32(reader["rentalID"].ToString());
                    returnTransaction.transactionID = Convert.ToInt32(reader["transactionID"].ToString());
                    returnTransaction.daily_Rate = Convert.ToDecimal(reader["daily_Rate"].ToString());
                    returnTransaction.fine_Rate = Convert.ToDecimal(reader["fine_Rate"].ToString());
                    returnTransaction.memberID = Convert.ToInt32(reader["memberID"].ToString());
                    listReturnTransaction.Add(returnTransaction);
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
            return listReturnTransaction;
        }

        public static List<Member> GetMemberByName(string memberName)
        {

            List<Member> memberList = new List<Member>();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT m.memberID FROM member m " +
                "WHERE UPPER(m.fname) + UPPER(m.lname) LIKE @memberName";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@memberName", memberName);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Member member = new Member();
                    member.memberID = Convert.ToInt32(reader["memberID"].ToString());
                    memberList.Add(member);
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
            return memberList;
        }

        public static List<Member> GetMemberByPhone(string phoneNumber)
        {

            List<Member> memberList = new List<Member>();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT m.memberID FROM member m " +
                "WHERE m.homePhone like @phoneNumber";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Member member = new Member();
                    member.memberID = Convert.ToInt32(reader["memberID"].ToString());
                    memberList.Add(member);
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
            return memberList;
        }

        public static bool ReturnFurniture(int rentalID)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string updateStatement =
                "UPDATE Rental " +
                "SET return_date = GETDATE() WHERE " +
                "rentalID = @rentalID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@rentalID", rentalID);
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

        public static int ReturnFurnitureTransaction(DateTime date, decimal amount, string comment, int employeeID, decimal fines)
        {
            int transactionID = 0;
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string insertStatement =
                "INSERT INTO Transactions " +
                "(date, amount, comment, employeeID, fines) " +
                "VALUES(@date, @amount, @comment, @employeeID, @fines)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@date", date);
            insertCommand.Parameters.AddWithValue("@amount", amount);
            insertCommand.Parameters.AddWithValue("@comment", comment);
            insertCommand.Parameters.AddWithValue("@employeeID", employeeID);
            insertCommand.Parameters.AddWithValue("@fines", fines);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Transactions') FROM Transactions";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                transactionID = Convert.ToInt32(selectCommand.ExecuteScalar());
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

        public static bool RentalReturnTransaction(int transactionID, int rentalID)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string insertStatement =
                "INSERT INTO Rental_return_transaction " +
                "(transactionID, rentalID) " +
                "VALUES(@transactionID, @rentalID)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@transactionID", transactionID);
            insertCommand.Parameters.AddWithValue("@rentalID", rentalID);
            try {
                connection.Open();
                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                {
                  return true;
                }
                else return false;
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

        public static int GetEmployeeID(string login)
        {
            int employeeID = 0;
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectStatement =
                "SELECT employeeID from login " +
                "WHERE userID = @login";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@login", login);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    employeeID = Convert.ToInt32(reader["employeeID"].ToString());
                }
                else
                {
                    employeeID = 0;
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
            return employeeID;
        }
    }
}
