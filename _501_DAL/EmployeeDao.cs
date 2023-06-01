using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _501_Entity;

namespace _501_DAL
{
    public class EmployeeDao
    {
        //NTier

        //DAL 
            //EmployeeDao
            //CategoryDao
            //ProductCategoryDao
        
        //BLL
            //kontrol, mantık, dönüşüm, yorum, filtreleme

        //UI -- API
            //ekran/servis odaklı

        //Entity
        //DTO
        //Core -common
        //

       public List<Employee> GetEmployees()
        {
            //SqlConnection
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Server=.\\SQLEXPRESS;Database=Northwind;User Id=sa;Password=1234;"; //   \n \t            


            //SqlCommand
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * FROM Employees";

            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.CommandText = "SpIsmi";
            //SqlParameter pr = new SqlParameter();
            //pr.ParameterName = "@parametername";
            //pr.Value = "değer";
            //cmd.Parameters.Add(pr);

            if (cnn.State != System.Data.ConnectionState.Open)
            {
                cnn.Open();
            }

            // cmd.ExecuteNonQuery();//crud
            // cmd.ExecuteScalar(); //1. satırın 1. kolonu --Aggregate
            SqlDataReader reader = cmd.ExecuteReader(); //result set 

            List<Employee> employees = new List<Employee>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeId = reader.GetInt32(0);
                    employee.FirstName = reader["FirstName"].ToString();
                    employee.LastName = reader["LastName"].ToString();
                    employee.Title = reader["Title"].ToString();
                    employees.Add(employee);

                }
            }

            cnn.Close();
            cnn.Dispose();
            cmd.Dispose();

            return employees;
        }
    }
}
