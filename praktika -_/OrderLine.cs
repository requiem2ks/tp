using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace praktika1
{   
    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Amount { get; set; }
        public bool? TheNeedForCustomization { get; set; }
        
    }
}
