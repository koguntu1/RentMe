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
    class EmployeeDAL
    {
        public static Employee GetEmployee(int employeeID)
        {
            Employee employee = new Employee();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT employeeID, fname, middleInitial, lname, dateOfBirth, gender, homePhone, Address1, Address2, City, State, PostalCode " +
                "FROM employee " +
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
                    employee.employeeID = Convert.ToInt32(reader["employeeID"].ToString());
                    employee.fname = reader["fname"].ToString();
                    employee.middleInitial = reader["middleInitial"].ToString();
                    employee.lname = reader["lname"].ToString();
                    employee.dateOfBirth = (DateTime)reader["dateOfBirth"];
                    employee.gender = reader["gender"].ToString();
                    employee.homePhone = reader["homePhone"].ToString();
                    employee.Address1 = reader["Address1"].ToString();
                    employee.Address2 = reader["Address2"].ToString();
                    employee.City = reader["City"].ToString();
                    employee.State = reader["State"].ToString();
                    employee.PostalCode = reader["PostalCode"].ToString();


                }
                else
                {
                    employee = null;
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
            return employee;
        }
    }
}
