using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _501_Entity;
using _501_BLL;
using Framework;

namespace _501_UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bll çağır
            //kullanıcıdan data al-göster
            EmployeesQuery empQuery = new EmployeesQuery();
           IEnumerable<Employee> employees= empQuery.GetEmployees();

            foreach (var employee in employees)
            {
                MyLibrary.EkranaYaz(employee.FirstName + " " + employee.LastName+"\n");
            }

            MyLibrary.Bekle();
        }
    }
}
