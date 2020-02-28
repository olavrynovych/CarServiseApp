using CarServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp
{
    public class EmployeeRepository
    {
        public static void InsertEmployeeInfo(Employee employee)
        {
            var dbManager = new SqlHelper(ConfigurationManager.ConnectionStrings["connectionStringCarService"].ToString());
            var parameters = new List<SqlParameter>();
            parameters.Add(dbManager.CreateParameter("@employeeName", 50, employee.FirstName, System.Data.DbType.String));
            parameters.Add(dbManager.CreateParameter("@employeeSecondName", employee.LastName, System.Data.DbType.String));
            parameters.Add(dbManager.CreateParameter("@employeePhone", employee.Phone, System.Data.DbType.String));
            parameters.Add(dbManager.CreateParameter("@description", employee.Description, System.Data.DbType.String));
            parameters.Add(dbManager.CreateParameter("@id", employee.Id, System.Data.DbType.Int32));
            //parameters.Add(helper.CreateParameter("@createdAt", client.CreatedAt, System.Data.DbType.DateTime));

            int lastId = 0;
            dbManager.Insert("InsertEmployee", System.Data.CommandType.StoredProcedure, parameters.ToArray(), out lastId);

            Console.WriteLine($"INSERTED ID: {lastId}.");
        }

        public static IReadOnlyCollection<Employee> GetEmployees()
        {
            var result = new List<Employee>();
            var dbManager = new SqlHelper(ConfigurationManager.ConnectionStrings["connectionStringCarService"].ToString());
            var table = dbManager.GetDataTable("select * from dbo.Employees order by employeeSecondName", System.Data.CommandType.Text);
            foreach (System.Data.DataRow row in table.Rows)
            {
                result.Add(new Employee 
                {
                    Id = int.Parse(row["employeeId"].ToString()),
                    FirstName = row["employeeName"].ToString(),
                    LastName = row["employeeSecondName"].ToString()
                });
            }

            return result;
        }
    }
}
