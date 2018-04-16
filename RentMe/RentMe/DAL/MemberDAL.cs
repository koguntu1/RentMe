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
        public static List<Member> GetMemberList()
        {
            List<Member> memberList = new List<Member>();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectStatement =
                "SELECT * FROM Member ORDER BY fname";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Member member = new Member();
                    member.memberID = (int)reader["memberID"];
                    member.fullname = reader["fname"].ToString() + ", " + reader["lname"].ToString();
                    memberList.Add(member);
                }
                //add an empty Employee
                Member memberEmpty = new Member();
                memberEmpty.memberID = -1;
                memberEmpty.fullname = "";
                memberList.Add(memberEmpty);
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


        public static Member GetMemberByName(string firstName, string lastName)
        {
            Member member = new Member();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT memberID, fname, middleInitial, lname, dateOfBirth, gender, homePhone, Address1, Address2, City, State, PostalCode " +
                "FROM member " +
                "WHERE fname = @fname " +
                "AND lname = @lname";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@fname", firstName);
            selectCommand.Parameters.AddWithValue("@lname", lastName);
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
                    member.City = reader["City"].ToString();
                    member.State = reader["State"].ToString();
                    member.PostalCode = reader["PostalCode"].ToString();


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

        public static Member GetMemberByPhone(string phoneNumber)
        {
            Member member = new Member();
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string selectstatement =
                "SELECT memberID, fname, middleInitial, lname, dateOfBirth, gender, homePhone, Address1, Address2, City, State, PostalCode " +
                "FROM member " +
                "WHERE homePhone = @homePhone";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@homePhone", phoneNumber);
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
                    member.City = reader["City"].ToString();
                    member.State = reader["State"].ToString();
                    member.PostalCode = reader["PostalCode"].ToString();


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

        public static int AddMember(Member member)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string insertStatement =
                "INSERT Member " +
                  "(fname, middleInitial, lname, dateOfBirth, gender, homePhone, Address1, Address2, City, State, PostalCode) " +
                "VALUES (@fname, @middleInitial, @lname, @dateOfBirth, @gender, @homePhone, @Address1, @Address2, @City, @State, @PostalCode)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@fname", member.fname);
            insertCommand.Parameters.AddWithValue("@middleInitial", member.middleInitial);
            insertCommand.Parameters.AddWithValue("@lname", member.lname);
            insertCommand.Parameters.AddWithValue("@dateOfBirth", member.dateOfBirth);
            insertCommand.Parameters.AddWithValue("@gender", member.gender);
            insertCommand.Parameters.AddWithValue("@homePhone", member.homePhone);
            insertCommand.Parameters.AddWithValue("@Address1", member.Address1);
            insertCommand.Parameters.AddWithValue("@Address2", member.Address2);
            insertCommand.Parameters.AddWithValue("@City", member.City);
            insertCommand.Parameters.AddWithValue("@State", member.State);
            insertCommand.Parameters.AddWithValue("@PostalCode", member.PostalCode);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Member') FROM Member";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int memberID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return memberID;
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

        public static bool UpdateMember(Member oldMember, Member newMember)
        {
            SqlConnection connection = RentMeDBConnection.GetConnection();
            string updateStatement =
                "UPDATE Member SET " +
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
                  "PostalCode = @NewPostalCode " +
                "WHERE memberID = @OldmemberID " +
                  "AND fname = @Oldfname " +
                  "AND middleInitial = @OldmiddleInitial " +
                  "AND lname = @Oldlname";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@Newfname", newMember.fname);
            updateCommand.Parameters.AddWithValue("@NewmiddleInitial", newMember.middleInitial);
            updateCommand.Parameters.AddWithValue("@Newlname", newMember.lname);
            updateCommand.Parameters.AddWithValue("@NewdateOfBirth", newMember.dateOfBirth);
            updateCommand.Parameters.AddWithValue("@Newgender", newMember.gender);
            updateCommand.Parameters.AddWithValue("@NewhomePhone", newMember.homePhone);
            updateCommand.Parameters.AddWithValue("@NewAddress1", newMember.Address1);
            updateCommand.Parameters.AddWithValue("@NewAddress2", newMember.Address2);
            updateCommand.Parameters.AddWithValue("@NewCity", newMember.City);
            updateCommand.Parameters.AddWithValue("@NewState", newMember.State);
            updateCommand.Parameters.AddWithValue("@NewPostalCode", newMember.PostalCode);
            updateCommand.Parameters.AddWithValue("@OldmemberID", oldMember.memberID);
            updateCommand.Parameters.AddWithValue("@Oldfname", oldMember.fname);
            updateCommand.Parameters.AddWithValue("@OldmiddleInitial", oldMember.middleInitial);
            updateCommand.Parameters.AddWithValue("@Oldlname", oldMember.lname);
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
    }
}
