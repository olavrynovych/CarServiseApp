using CarServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp
{
    class ClientHelper
    {
        public static void InsertClientInfo(SqlHelper helper, Client client)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(helper.CreateParameter("@customerName", 50, client.FirstName, System.Data.DbType.String));
            parameters.Add(helper.CreateParameter("@customerSecondName", client.LastName, System.Data.DbType.String));
            parameters.Add(helper.CreateParameter("@customerPhone", client.CellPhone, System.Data.DbType.String));
            parameters.Add(helper.CreateParameter("@description", client.Description, System.Data.DbType.String));
            parameters.Add(helper.CreateParameter("@id", client.Id, System.Data.DbType.Int32));
            //parameters.Add(helper.CreateParameter("@createdAt", client.CreatedAt, System.Data.DbType.DateTime));

            int lastId = 0;//Wrong value, how to get value to code from sproc????
            helper.Insert("InsertCustomer", System.Data.CommandType.StoredProcedure, parameters.ToArray(), out lastId);

            Console.WriteLine($"INSERTED ID: {lastId}.");
        }
    }
}
