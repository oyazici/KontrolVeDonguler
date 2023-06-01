using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _501_Entity;
using _501_DAL;

namespace _501_BLL
{
    public class EmployeesQuery
    {
        //dal katmanını çağır. 
        //üzerinde mantıksal işlemlerini yap

        public List<Employee> GetEmployees() //osman gelmesin
        {
            EmployeeDao empDao = new EmployeeDao();
            List<Employee> employees = empDao.GetEmployees();
            employees = employees.Where(e => e.FirstName != "Osman").ToList();
            return employees;
        }

    }
}
