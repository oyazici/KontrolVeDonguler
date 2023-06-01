using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _401_AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Ado.Net
            ////1- Connected     //anlık değişim 
            ////2- DisConnected  //pocket satiş modeli



            ////SqlConnection
            //SqlConnection cnn = new SqlConnection();
            //cnn.ConnectionString = "Server=.\\SQLEXPRESS;Database=Northwind;User Id=sa;Password=1234;"; //   \n \t            


            ////SqlCommand
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = cnn;
            //cmd.CommandText = "SELECT * FROM Employees";

            ////cmd.CommandType = System.Data.CommandType.StoredProcedure;
            ////cmd.CommandText = "SpIsmi";
            ////SqlParameter pr = new SqlParameter();
            ////pr.ParameterName = "@parametername";
            ////pr.Value = "değer";
            ////cmd.Parameters.Add(pr);

            //if (cnn.State != System.Data.ConnectionState.Open)
            //{
            //    cnn.Open();
            //}

            //// cmd.ExecuteNonQuery();//crud
            //// cmd.ExecuteScalar(); //1. satırın 1. kolonu --Aggregate
            //SqlDataReader reader = cmd.ExecuteReader(); //result set 

            //List<Employee> employees = new List<Employee>();

            //ICollection<Employee> employees1 = createCollection<Employee>();
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        Employee employee = new Employee();
            //        employee.EmployeeId = reader.GetInt32(0);
            //        employee.FirstName = reader["FirstName"].ToString();
            //        employee.LastName = reader["LastName"].ToString();
            //        employee.Title = reader["Title"].ToString();
            //        employees1.Add(employee);

            //    }
            //}

            //cnn.Close();
            //cnn.Dispose();
            //cmd.Dispose();

            Employee employee = new Employee();
            employee.FirstName = "Osman";
            employee.LastName = "Yazıcı";
            employee.Title = "Mimar Yazılım Mühendisi";

            EmployeeInsert(employee);
            

            int a = 5;

        }


        public static ICollection<T> createCollection<T>() where T : class, new()
        {
            return new List<T>();
        }


        public static int EmployeeInsert(Employee employee)
        {
            SqlConnection cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;User Id=sa;Password=1234;");
            
            SqlCommand cmd = new SqlCommand("Insert Into Employees (LastName,FirstName,Title) values('"+employee.LastName+"',@FirstName,'"+employee.Title+"')", cnn);  //sql injection
            cmd.Parameters.Add(new SqlParameter("@FirstName", employee.FirstName));
            if(cnn.State!=ConnectionState.Open)
            {
                cnn.Open();
            }

            int ess=  cmd.ExecuteNonQuery();
            cnn.Close();
            cnn.Dispose();
            cmd.Dispose();
            return ess;
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

    }
}
