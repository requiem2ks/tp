using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Title { get; set; }
        public string? Price { get; set; }
        public bool? TheNeedForCustomization { get; set; }
        public int? ProviderOfProducts { get; set; }
    }
}