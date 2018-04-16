using RentMe.DAL;
using RentMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Controller
{
    class RentalItemController
    {
        public int AddRentalItem(RentalItem rentalItem)
        {
            return RentalItemDAL.AddRentalItem(rentalItem);
        }
    }
}
