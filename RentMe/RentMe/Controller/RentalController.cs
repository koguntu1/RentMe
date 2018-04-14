using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentMe.DAL;

namespace RentMe.Controller
{
    public static class RentalController
    {
        public static DataSet GetRentHistory(int employeeID, int memberID, DateTime fromDate, DateTime toDate)
        {
            return RentalItemDAL.GetRentHistory(employeeID, memberID, fromDate, toDate);
        }

        public static DataSet GetReturnHistory(int employeeID, int memberID, DateTime fromDate, DateTime toDate)
        {
            return RentalItemDAL.GetReturnHistory(employeeID, memberID, fromDate, toDate);
        }
    }
}
