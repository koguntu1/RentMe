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
        public static Login GetLogin(int employeeID)
        {
            Login login = new Login();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT login1, password, employeeID " +
                "FROM login " +
                "WHERE employeeID = @employeeID";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@employeeID", employeeID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    login.login1 = reader["description"].ToString();
                    login.password = reader["description"].ToString();
                    login.employeeID = Convert.ToInt32(reader["categoryID"].ToString());

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
    }
}
