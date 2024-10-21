using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITempalate.Domain
{
    public class Pricebook2Items
    {
        public int Store { get; set; }
        public int Sku { get; set; }
        public int Threshold { get; set; }
        public bool ExcludeMargin { get; set; }
        public decimal? OverridePrice { get; set; }
        public bool InMetroMart { get; set; }
        public bool InPickARoo { get; set; }
        public bool InGrabMart { get; set; }
        public bool InPandaMart { get; set; }
    }
}
