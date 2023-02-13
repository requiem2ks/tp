using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop
{
    public class ToolSetting
    {
        public int ToolToolSettingId { get; set; }
        public bool? TheNeedForCustomization { get; set; }
        public int? ProductId { get; set; }
        public int? CustomizationPrice { get; set; }
        public string? TypeOfTool { get; set; }
        public int? OrderId { get; set; }

    }
}