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
    
        public int FurnitureID { get; set; }
        public int ItemID { get; set; }
        public string Description { get; set; }
        public int StyleID { get; set; }
        public string Style { get; set; }
        public string Category { get; set; }
        
        public int CategoryID { get; set; }
        public decimal Fine_Rate { get; set; }
        public decimal Daily_Rate { get; set; }
    
        //public virtual Category category { get; set; }
       
    }
}
