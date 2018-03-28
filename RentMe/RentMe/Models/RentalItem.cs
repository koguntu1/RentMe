//------------------------------------------------------------------------------
//cs6232
//------------------------------------------------------------------------------

namespace RentMe.Models
{
   
    
    public partial class RentalItem
    {
       
        public RentalItem()
        {
          
        }
    
        public int rentalItemID { get; set; }
        public int rentalTransactionID { get; set; }
        public int itemID { get; set; }
        public int  quantity { get; set; }
    
       
    }
}
