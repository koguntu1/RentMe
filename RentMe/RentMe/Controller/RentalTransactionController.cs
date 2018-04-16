using RentMe.DAL;
using RentMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Controller
{
    class RentalTransactionController
    {
        public int AddRentalTransaction(RentalTransaction rentalTransaction)
        {
            return RentalTransactionDAL.AddRentalTransaction(rentalTransaction);
        }
    }
}
