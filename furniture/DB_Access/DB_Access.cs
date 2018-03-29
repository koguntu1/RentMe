using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furniture
{
    class DB_Access
    {
        SqlConnection conn;
        public DB_Access()
        {
            conn = DBconnection.GetConnection();
        }


       public bool addCustomer(String id, String fname, String lname, String sex, String dob, String address, String phone, String ssn)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into customer values('" + id + "','" + fname + "','" + lname + "','" + sex + "','" + dob + "','" + address + "','" + phone + "','" + ssn + "')";
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Data input");
                return false;
            }
        }

        public bool addEmployee(String id, String fname, String lname, String sex, String dob, String address, String phone, String ssn)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into employee values('" + id + "','" + fname + "','" + lname + "','" + sex + "','" + dob + "','" + address + "','" + phone + "','" + ssn + "')";
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Data input");
                return false;
            }
        }

        public DataSet searchCustomer(String data)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                DataSet dt = new DataSet();
                long n;
                if (!long.TryParse(data, out n))
                {
                    cmd = new SqlCommand("searchCustomerByName", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Firstname", data.Split(' ')[0]);
                    cmd.Parameters.AddWithValue("@Lastname", data.Split(' ')[1]);
                }
                else
                {
                    cmd = new SqlCommand("searchCustomerByPhone", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Phone", data);

                }
       
                
                DataSet dsCustomers = new DataSet();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                   

                    dsCustomers.Tables.Add("Customers");

                 
                    dsCustomers.Tables[0].Load(sdr);
                }
                conn.Close();
                return dsCustomers;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool updateCustomer(String id, String fname, String lname, String sex, String dob, String address, String phone, String ssn)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update customer set FName='" + fname + "',LName='" + lname + "',Sex='" + sex + "',DOB='" + dob + "',E_Address='" + address + "',Phone_no='" + phone + "',SSN='" + ssn + "' where C_id='" + id + "'";
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input Data");
                return false;
            }
        }
        public DataSet furnitureTypes(String field)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                DataSet dt = new DataSet();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select DISTINCT " + field + " from furniture";
                cmd.ExecuteNonQuery();

                DataSet dsCustomers = new DataSet();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {


                    dsCustomers.Tables.Add("Customers");

                    dsCustomers.Tables[0].Load(sdr);
                }
                conn.Close();
                return dsCustomers;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet Searchfurniture(String field, String value, string procedurename)
        {

            SqlCommand cmd = conn.CreateCommand();
            DataSet dt = new DataSet();
            cmd = new SqlCommand(procedurename, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@"+field, value);

            conn.Open();
            DataSet dsCustomers = new DataSet();
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
  

                dsCustomers.Tables.Add("Customers");


                dsCustomers.Tables[0].Load(sdr);
            }
            conn.Close();
            return dsCustomers;
        }

        public bool updateLogin(String username, String password)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Login set password= @password where login = @username";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input Data");
                return false;
            }
        }

        public bool login(String username, String password)
        {
            bool lin = false;
            try
            {
                string selectStatement =
                "SELECT * FROM Login WHERE login = @username and password = @password";
                SqlCommand cmd = new SqlCommand(selectStatement, conn);
                DataSet dt = new DataSet();
                //cmd = new SqlCommand("loginEmployee", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);


                conn.Open();
                DataSet dsCustomers = new DataSet();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
    
                    dsCustomers.Tables.Add("Customers");

                    dsCustomers.Tables[0].Load(sdr);
                }
                conn.Close();
               
                foreach (DataRow row in dsCustomers.Tables[0].Rows)
                {
                    if (row[0].ToString() == username && row[1].ToString() == password)
                    {
                        //MessageBox.Show("Hello, "+row[1]);
                        lin = true;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return lin;
        }

        public void addRental(String C_id, String E_id, String item_num, String rentalDate, String dueDate, String returnDate, String rentalPrice)
        {
            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }
                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Rental values('" + C_id + "','" + E_id + "'," + item_num + ",'" + rentalDate + "','" + dueDate + "','" + returnDate + "'," + rentalPrice + ")";
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet FindRental(String C_id)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand cmd = conn.CreateCommand();
            try
            {

                DataSet dt = new DataSet();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select item_num, Rental_date,due_date,Return_data, Rental_price From Rental where C_id ='" + C_id + "'";

                DataSet dsCustomers = new DataSet();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {


                    dsCustomers.Tables.Add("Customers");


                    dsCustomers.Tables[0].Load(sdr);
                }
                conn.Close();
                return dsCustomers;
            }catch(Exception)
            {

                throw;
            }

        }

        public void DeleteRental(String C_id)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                DataSet dt = new DataSet();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete  From Rental where C_id ='" + C_id + "'";
                cmd.ExecuteNonQuery();
                // cmd.ExecuteNonQuery();
            }catch(Exception)
            {
                throw;
            }


        }
        public DataSet Employee(String username, String password)
        {
            bool lin = false;
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                DataSet dt = new DataSet();
                cmd = new SqlCommand("loginEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                DataSet dsCustomers = new DataSet();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
  

                    dsCustomers.Tables.Add("Customers");

  
                    dsCustomers.Tables[0].Load(sdr);
                }
                conn.Close();
                return dsCustomers;



            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataSet furniture(String id)
        {

        try
            {
                SqlCommand cmd = conn.CreateCommand();
                DataSet dt = new DataSet();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * From furniture where item_num ='" + id + "'";

                conn.Open();
                DataSet dsCustomers = new DataSet();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {


                    dsCustomers.Tables.Add("Customers");


                    dsCustomers.Tables[0].Load(sdr);
                }
                conn.Close();
                return dsCustomers;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
