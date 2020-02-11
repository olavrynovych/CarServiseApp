using CarServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp
{
    class EmployeeHelper
    {
        public static void InsertEmployeeInfo(SqlHelper helper, Employee employee)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(helper.CreateParameter("@employeeName", 50, employee.FirstName, System.Data.DbType.String));
            parameters.Add(helper.CreateParameter("@employeeSecondName", employee.LastName, System.Data.DbType.String));
            parameters.Add(helper.CreateParameter("@employeePhone", employee.Phone, System.Data.DbType.String));
            parameters.Add(helper.CreateParameter("@description", employee.Description, System.Data.DbType.String));
            parameters.Add(helper.CreateParameter("@id", employee.Id, System.Data.DbType.Int32));
            //parameters.Add(helper.CreateParameter("@createdAt", client.CreatedAt, System.Data.DbType.DateTime));

            int lastId = 0;//Wrong value, how to get value to code from sproc????
            helper.Insert("InsertEmployee", System.Data.CommandType.StoredProcedure, parameters.ToArray(), out lastId);

            Console.WriteLine($"INSERTED ID: {lastId}.");
        }
    }
}
