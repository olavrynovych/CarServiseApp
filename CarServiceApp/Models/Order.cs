using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public string OrderDetails { get; set; }
        public string IssueWithCar { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime CreatedAtDate { get; set; }
    }
}