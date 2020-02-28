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
    public class OrdersRepository
    {
        public static void InsertOrderInfo(Order order)
        {
            var dbManager = new SqlHelper(ConfigurationManager.ConnectionStrings["connectionStringCarService"].ToString());
            var parameters = new List<SqlParameter>();
            parameters.Add(dbManager.CreateParameter("@employeeId", 50, order.EmployeeId, System.Data.DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@customerId", order.CustomerId, System.Data.DbType.Int32));

            parameters.Add(dbManager.CreateParameter("@appointmentDate", order.AppointmentDate, System.Data.DbType.DateTime));
            parameters.Add(dbManager.CreateParameter("@orderDetails", order.OrderDetails, System.Data.DbType.String));
            parameters.Add(dbManager.CreateParameter("@issuesWithCar", order.IssueWithCar, System.Data.DbType.String));

            parameters.Add(dbManager.CreateParameter("@id", order.Id, System.Data.DbType.Int32));

            int lastId = 0;
            dbManager.Insert("InsertOrder", System.Data.CommandType.StoredProcedure, parameters.ToArray(), out lastId);

            Console.WriteLine($"INSERTED ID: {lastId}.");
        }
    }
}