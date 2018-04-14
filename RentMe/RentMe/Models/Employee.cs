//------------------------------------------------------------------------------
// cs6232
//------------------------------------------------------------------------------

namespace RentMe.Models
{
   
    
    public partial class Employee
    {
        public Employee()
        {
           
        }
    
        public int employeeID { get; set; }
        public string fname { get; set; }
        public string middleInitial { get; set; }
        public string lname { get; set; }
        public string fullname { get; set; }
        public System.DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public string homePhone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string admin { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    
    }
}
