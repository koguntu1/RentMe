﻿using RentMe.Models;
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

        public static bool updatePassword(string username, string newpass)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string updateStament = "update Login set password= @newpassword where userID = @username";
            SqlCommand updateCommand = new SqlCommand(updateStament, connection);
            updateCommand.Parameters.AddWithValue("@username", username);
            updateCommand.Parameters.AddWithValue("@newpassword", newpass);
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

        public static bool checkCurrentPassword(string username, string password)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectStament = "select password from Login where userID = @username and password = @password";
            SqlCommand selectCommand = new SqlCommand(selectStament, connection);
            selectCommand.Parameters.AddWithValue("@username", username);
            selectCommand.Parameters.AddWithValue("@password", password);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                bool result = false;
                if (reader.Read())
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                reader.Close();
                return result;
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
