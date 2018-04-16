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

        public static int AddEmployee(Employee employee)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string insertStatement =
                "INSERT Employee " +
                  "(fname, middleInitial, lname, dateOfBirth, gender, homePhone, Address1, Address2, City, State, PostalCode, admin) " +
                "VALUES (@fname, @middleInitial, @lname, @dateOfBirth, @gender, @homePhone, @Address1, @Address2, @City, @State, @PostalCode, @admin)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@fname", employee.fname);
            insertCommand.Parameters.AddWithValue("@middleInitial", employee.middleInitial);
            insertCommand.Parameters.AddWithValue("@lname", employee.lname);
            insertCommand.Parameters.AddWithValue("@dateOfBirth", employee.dateOfBirth);
            insertCommand.Parameters.AddWithValue("@gender", employee.gender);
            insertCommand.Parameters.AddWithValue("@homePhone", employee.homePhone);
            insertCommand.Parameters.AddWithValue("@Address1", employee.Address1);
            insertCommand.Parameters.AddWithValue("@Address2", employee.Address2);
            insertCommand.Parameters.AddWithValue("@City", employee.City);
            insertCommand.Parameters.AddWithValue("@State", employee.State);
            insertCommand.Parameters.AddWithValue("@PostalCode", employee.PostalCode);
            insertCommand.Parameters.AddWithValue("@admin", employee.admin);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Employee') FROM Employee";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int employeeID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return employeeID;
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

        public static bool UpdateEmployee(Employee oldEmployee, Employee newEmployee)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string updateStatement =
                "UPDATE Employee SET " +
                  "fname = @Newfname, " +
                  "middleInitial = @NewmiddleInitial, " +
                  "lname = @Newlname, " +
                  "dateOfBirth = @NewdateOfBirth, " +
                  "gender = @Newgender, " +
                  "homePhone = @NewhomePhone, " +
                  "Address1 = @NewAddress1, " +
                  "Address2 = @NewAddress2, " +
                  "City = @NewCity, " +
                  "State = @NewState, " +
                  "PostalCode = @NewPostalCode, " +
                  "Admin = @NewAdmin " +
                "WHERE employeeID = @OldemployeeID " +
                "AND fname = @Oldfname AND middleInitial = @OldmiddleInitial AND lname = @Oldlname " +
                "AND homePhone = @OldhomePhone AND city = @Oldcity AND state = @Oldstate " +
                "AND PostalCode = @OldPostalCode AND Admin = @OldAdmin AND dateOfBirth = @OlddateOfBirth";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@Newfname", newEmployee.fname);
            updateCommand.Parameters.AddWithValue("@NewmiddleInitial", newEmployee.middleInitial);
            updateCommand.Parameters.AddWithValue("@Newlname", newEmployee.lname);
            updateCommand.Parameters.AddWithValue("@NewdateOfBirth", newEmployee.dateOfBirth);
            updateCommand.Parameters.AddWithValue("@Newgender", newEmployee.gender);
            updateCommand.Parameters.AddWithValue("@NewhomePhone", newEmployee.homePhone);
            updateCommand.Parameters.AddWithValue("@NewAddress1", newEmployee.Address1);
            updateCommand.Parameters.AddWithValue("@NewAddress2", newEmployee.Address2);
            updateCommand.Parameters.AddWithValue("@NewCity", newEmployee.City);
            updateCommand.Parameters.AddWithValue("@NewState", newEmployee.State);
            updateCommand.Parameters.AddWithValue("@NewPostalCode", newEmployee.PostalCode);
            updateCommand.Parameters.AddWithValue("@NewAdmin", newEmployee.admin);
            updateCommand.Parameters.AddWithValue("@OldemployeeID", oldEmployee.employeeID);
            updateCommand.Parameters.AddWithValue("@Oldfname", oldEmployee.fname);
            updateCommand.Parameters.AddWithValue("@OldmiddleInitial", oldEmployee.middleInitial);
            updateCommand.Parameters.AddWithValue("@Oldlname", oldEmployee.lname);
            updateCommand.Parameters.AddWithValue("@OlddateOfBirth", oldEmployee.dateOfBirth);
            updateCommand.Parameters.AddWithValue("@Oldgender", oldEmployee.gender);
            updateCommand.Parameters.AddWithValue("@OldhomePhone", oldEmployee.homePhone);
            updateCommand.Parameters.AddWithValue("@OldAddress1", oldEmployee.Address1);
            updateCommand.Parameters.AddWithValue("@OldAddress2", oldEmployee.Address2);
            updateCommand.Parameters.AddWithValue("@OldCity", oldEmployee.City);
            updateCommand.Parameters.AddWithValue("@OldState", oldEmployee.State);
            updateCommand.Parameters.AddWithValue("@OldPostalCode", oldEmployee.PostalCode);
            updateCommand.Parameters.AddWithValue("@OldAdmin", oldEmployee.admin);
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

        public static Employee GetEmployeeByID(int employeeID)
        {
            Employee employee = new Employee();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT employeeID, fname, middleInitial, lname, dateOfBirth, gender, homePhone, Address1, Address2, City, State, PostalCode, Admin " +
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
