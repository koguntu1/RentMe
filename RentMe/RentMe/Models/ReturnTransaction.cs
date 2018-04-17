using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Models;
using RentMe.Controller;

namespace RentMe.Models
{
    
    
    public partial class ReturnTransaction
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string description { get; set; }
        public string style { get; set; }
        public string category { get; set; }
        public System.DateTime rental_date { get; set; }
        public System.DateTime expected_return { get; set; }
        public int returnTransactionID { get; set; }
        public System.DateTime transaction_date { get; set; }
        public decimal amount { get; set; }
        public string comment { get; set; }
        public int itemID { get; set; }
        public decimal fines { get; set; }
        public System.DateTime return_date { get; set; }
        public int employeeID { get; set; }
        public int memberID { get; set; }
        public int transactionID { get; set; }
        public int rentalID { get; set; }
        public decimal daily_Rate { get; set; }
        public decimal fine_Rate { get; set; }
        
    
      
    }
}
