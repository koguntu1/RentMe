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
    class MemberDAL
    {
        public static Member GetMember(int memberID)
        {
            Member member = new Member();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT memberID, fname, middleInitial, lname, dateOfBirth, gender, Address1, Address2, City, State, PostalCode " +
                "FROM member " +
                "WHERE memberID = @memberID";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@memberID", memberID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    member.memberID = Convert.ToInt32(reader["memberID"].ToString());
                    member.fname = reader["fname"].ToString();
                    member.middleInitial = reader["middleInitial"].ToString();
                    member.lname = reader["lname"].ToString();
                    member.dateOfBirth = (DateTime)reader["dateOfBirth"];
                    member.gender = reader["gender"].ToString();
                    member.homePhone = reader["homePhone"].ToString();
                    member.Address1 = reader["Address1"].ToString();
                    member.Address2 = reader["Address2"].ToString();
                    member.homePhone = reader["City"].ToString();
                    member.homePhone = reader["State"].ToString();
                    member.homePhone = reader["PostalCode"].ToString();


                }
                else
                {
                    member = null;
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
            return member;
        }
    }
}
