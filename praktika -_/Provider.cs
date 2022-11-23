using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace praktika1
{
    public class Provider
    {
        public int ProviderId { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public int? PhoneNumber { get; set; }
    }
}
