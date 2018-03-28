//------------------------------------------------------------------------------
// cs6232
//------------------------------------------------------------------------------

namespace RentMe.Models
{
    
    
    public partial class ReturnTransaction
    {
        public int returnTransactionID { get; set; }
        public System.DateTime date { get; set; }
        public string amount { get; set; }
        public string comment { get; set; }
        public int rentalItemID { get; set; }
        public decimal fines { get; set; }
        public System.DateTime return_date { get; set; }
        public int employeeID { get; set; }
    
      
    }
}
