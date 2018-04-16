using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public bool IsAdminRole(string username, string password)
        {
            try
            {


                return LoginDAL.GetRole(username, password);

            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string GetLoginPassword(string username)
        {
            try
            {
                String password = LoginDAL.GetLoginPassword(username);

                return password;

            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool SetLoginPassword(string userID, string oldPassword, string newPassword)
        {
            try
            {


                return LoginDAL.SetLoginPassword(userID, oldPassword, newPassword);

            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        

        public Login getLoggedInUser(string username)
        {
            return LoginDAL.GetLogin(username, LoginDAL.GetLoginPassword(username));
        }
        
    }
}
