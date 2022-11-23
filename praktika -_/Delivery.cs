using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace praktika1
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public string? DeliveryStatus { get; set; }
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
