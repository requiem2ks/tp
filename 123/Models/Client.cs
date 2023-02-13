using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop
{
    public class Client
    {
        public int ClientId { get; set; }
        public string? FIOClient { get; set; }
        public string? ClientAddress { get; set; }
        public int? ClientPhoneNumber { get; set; }

    }
}