using RentMe.DAL;
using RentMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Controller
{
    class EmployeeController
    {
        public EmployeeController()
        {

        }
        public Employee GetEmployeeByName(string firstName, string lastName)
        {
            return EmployeeDAL.GetEmployeeByName(firstName, lastName);
        }

        public Employee GetEmployeeByPhone(string phoneNumber)
        {
            return EmployeeDAL.GetEmployeeByPhone(phoneNumber);
        }

        public int AddEmployee(Employee Employee)
        {
            return EmployeeDAL.AddEmployee(Employee);
        }

        public bool UpdateEmployee(Employee oldEmployee, Employee newEmployee)
        {
            return EmployeeDAL.UpdateEmployee(oldEmployee, newEmployee);
        }
    }
}
