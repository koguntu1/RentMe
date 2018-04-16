//------------------------------------------------------------------------------
//cs6232
//------------------------------------------------------------------------------

using System;

namespace RentMe.Models
{
   
    
    public partial class RentalItem
    {
       
        public RentalItem()
        {
          
        }
    
        public int rentalItemID { get; set; }
        public int memberID { get; set; }
        public DateTime expectedReturn { get; set; }
        public int itemID { get; set; }
        public DateTime returnDate { get; set; }
        public DateTime rentalDate { get; set; }
    
       
    }
}
