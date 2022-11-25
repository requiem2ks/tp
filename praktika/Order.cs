using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace praktika1
{
    public class Order
    { 
        public int OrderId { get; set; }
        public string? Status { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ExecutionDate { get; set; }
        public int? ClientID { get; set; }
        public int? EmployeeID { get; set; }
        public bool? OfflinePurchase { get; set; }
        public int? DeliveryID { get; set; }
        public bool? TheNeedForCustomization{ get; set; }

        public Employee? Employee { get; set; }

    }
}
