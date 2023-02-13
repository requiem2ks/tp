using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? FIOEmployee { get; set; }
        public string? JobTitle { get; set; }
        public Order? Order { get; set; }
    }
}