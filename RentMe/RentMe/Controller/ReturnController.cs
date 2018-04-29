using RentMe.DAL;
using RentMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Controller
{
    class ReturnController
    {
        public ReturnController()
        {
        }
        public List<ReturnTransaction> GetRentedFurniture(int memberID)
        {
            return ReturnTransactionDAL.GetRentedFurniture(memberID);
        }

        public List<Member> GetMemberByName(string memberName)
        {
            return ReturnTransactionDAL.GetMemberByName(memberName);
        }

        public List<Member> GetMemberByPhone(string phoneNumber)
        {
            return ReturnTransactionDAL.GetMemberByPhone(phoneNumber);
        }

        public bool ReturnFurniture(int rentalID, DateTime returnDate)
        {
            return ReturnTransactionDAL.ReturnFurniture(rentalID, returnDate);
        }

        public int ReturnFurnitureTransaction(DateTime date, decimal amount, string comment, int employeeID, decimal fines)
        {
            return ReturnTransactionDAL.ReturnFurnitureTransaction(date, amount, comment, employeeID, fines);
        }

        public bool RentalReturnTransaction(int transactionID, int rentalID)
        {
            return ReturnTransactionDAL.RentalReturnTransaction(transactionID, rentalID);
        }

        public int GetEmployeeID(string login)
        {
            return ReturnTransactionDAL.GetEmployeeID(login);
        }
    }
}
