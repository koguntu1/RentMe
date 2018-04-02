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
        public Member GetMemberByName(string firstName, string lastName)
        {
            return MemberDAL.GetMemberByName(firstName, lastName);
        }

        public Member GetMemberByPhone(string phoneNumber)
        {
            return MemberDAL.GetMemberByPhone(phoneNumber);
        }
    }
}
