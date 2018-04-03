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
        public static Employee GetEmployeeByName(string firstName, string lastName)
        {
            Employee employee = new Employee();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT employeeID, fname, middleInitial, lname, dateOfBirth, gender, homePhone, Address1, Address2, City, State, PostalCode, Admin " +
                "FROM employee " +
                "WHERE UPPER(fname) = @firstName AND UPPER(lname) = @lastName";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@firstName", firstName);
            selectCommand.Parameters.AddWithValue("@lastName", lastName);
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
                    employee.admin = reader["Admin"].ToString();


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

        public static Employee GetEmployeeByPhone(string phoneNumber)
        {
            Employee employee = new Employee();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT employeeID, fname, middleInitial, lname, dateOfBirth, gender, homePhone, Address1, Address2, City, State, PostalCode, Admin " +
                "FROM employee " +
                "WHERE homePhone = @phone";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@phone", phoneNumber);
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
                    employee.admin = reader["admin"].ToString();


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
