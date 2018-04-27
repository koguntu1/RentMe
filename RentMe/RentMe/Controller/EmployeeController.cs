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

        public List<Employee> GetemployeeList()
        {
            return EmployeeDAL.GetemployeeList();
        }

        public List<Employee> GetEmployeeByName(string employeeName)
        {
            return EmployeeDAL.GetEmployeeByName(employeeName);
        }

        public List<Employee> GetEmployeeByPhone(string phoneNumber)
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

        public bool UpdateEmployeePassword(Employee employee, string password)
        {
            return EmployeeDAL.UpdateEmployeePassword(employee, password);
        }

        public Employee GetEmployeeById(int employeeID)
        {
            return EmployeeDAL.GetEmployeeByID(employeeID);
        }
}
}
