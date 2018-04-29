using RentMe.DAL;
using RentMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Controller
{
    class MemberController
    {
        public MemberController()
        {

        }
        public List<Member> GetMemberList()
        {
            return MemberDAL.GetMemberList();
        }

        public Member GetMemberByName(string firstName, string lastName)
        {
            return MemberDAL.GetMemberByName(firstName, lastName);
        }

        public Member GetMemberByID(int id)
        {
            return MemberDAL.GetMemberByID(id);
        }

        public Member GetMemberByPhone(string phoneNumber)
        {
            return MemberDAL.GetMemberByPhone(phoneNumber);
        }


        public List<Member> GetMembersByName(string firstName, string lastName)
        {
            return MemberDAL.GetMembersByName(firstName, lastName);
        }

        public List<Member> GetMembersByPhone(string phoneNumber)
        {
            return MemberDAL.GetMembersByPhone(phoneNumber);
        }

        public int AddMember(Member member)
        {
            return MemberDAL.AddMember(member);
        }

        public bool UpdateMember(Member oldMember, Member newMember)
        {
            return MemberDAL.UpdateMember(oldMember, newMember);
        }
    }
}
