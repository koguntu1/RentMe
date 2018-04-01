using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Views;

namespace RentMe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new MDIView());
=======
            Application.Run(new CustomerRegistrationView());
>>>>>>> 70a6658e3972086a6323a4419a9d3b85218dded2
        }
    }
}
