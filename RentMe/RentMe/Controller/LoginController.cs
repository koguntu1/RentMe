using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentMe.DAL;
using RentMe.Models;

namespace RentMe.Controller
{
    class LoginController
    {
        public bool isValidLogin(string username, string password)
        {
            try
            {
                Login login = LoginDAL.GetLogin(username, password);

                if (login == null)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }      
            
        }
    }
}
