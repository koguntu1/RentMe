//------------------------------------------------------------------------------
// cs6232
//------------------------------------------------------------------------------

namespace RentMe.Models
{
   
    
    public partial class Furniture
    {
       
        public Furniture()
        {
            
        }
    
        public int furnitureID { get; set; }
        public string description { get; set; }
        public int styleID { get; set; }
        public int categoryID { get; set; }
        public decimal fine_Rate { get; set; }
        public decimal daily_Rate { get; set; }
    
        public virtual Category Category { get; set; }
       
    }
}
