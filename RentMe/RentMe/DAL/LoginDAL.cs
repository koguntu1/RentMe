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
    class LoginDAL
    {
        public static Login GetLogin(string userID, string password)
        {
            Login login = new Login();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT password, employeeID, userID " +
                "FROM login " +
                "WHERE userID = @userID AND password = @password";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@userID", userID);
            selectCommand.Parameters.AddWithValue("@password", password);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    login.login1 = reader["userID"].ToString();
                    login.password = reader["password"].ToString();
                    login.employeeID = Convert.ToInt32(reader["employeeID"].ToString());


                }
                else
                {
                    login = null;
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
            return login;
        }

        public static string GetLoginPassword(string userID)
        {
            string password;
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT password " +
                "FROM login " +
                "WHERE userID = @userID";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@userID", userID);

            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {

                    password = reader["password"].ToString();

                }
                else
                {
                    password = null;
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
            return password;
        }

        public static bool GetRole(string userID, string password)
        {
            string role;
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT e.admin " +
                 "FROM Employee e " +
                 "INNER JOIN Login l " +
                 "on e.employeeID = l.loginID " +
                 "WHERE l.loginID IN(SELECT loginID from Login WHERE userID = @userID AND password = @password)";

            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@userID", userID);
            selectCommand.Parameters.AddWithValue("@password", password);

            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {

                    role = reader["admin"].ToString();

                }
                else
                {
                    role = "N";
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

            if (role == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SetLoginPassword(string userID, string oldPassword, string newPassword)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string updatestatement =
                "UPDATE login SET " +
                "password = @newPassword " +
                "WHERE userID = @userID AND password = @oldPassword";
            SqlCommand updateCommand = new SqlCommand(updatestatement, connection);
            updateCommand.Parameters.AddWithValue("@userID", userID);
            updateCommand.Parameters.AddWithValue("@newPassword", newPassword);
            updateCommand.Parameters.AddWithValue("@oldPassword", oldPassword);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
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

    }
}
