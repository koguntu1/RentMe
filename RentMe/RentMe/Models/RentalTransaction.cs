//------------------------------------------------------------------------------
// cs6232
//------------------------------------------------------------------------------

using System;

namespace RentMe.Models
{
    
    
    public partial class RentalTransaction
    {
       
        public RentalTransaction()
        {
            
        }
    
        public int rentalTransactionID { get; set; }
        public DateTime transactionDate { get; set; }
        public double amount { get; set; }
        public String comment { get; set; }
        public int employeeID { get; set; }
        public double? fines { get; set; }
    
       
    }
}
