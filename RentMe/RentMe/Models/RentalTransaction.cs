//------------------------------------------------------------------------------
// cs6232
//------------------------------------------------------------------------------

namespace RentMe.Models
{
    
    
    public partial class RentalTransaction
    {
       
        public RentalTransaction()
        {
            
        }
    
        public int rentalTransactionID { get; set; }
        public int memberID { get; set; }
        public System.DateTime expected_return { get; set; }
        public System.DateTime rental_date { get; set; }
        public int employeeID { get; set; }
    
       
    }
}
