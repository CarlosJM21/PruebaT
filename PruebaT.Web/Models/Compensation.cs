using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Compensation
    {
        public string code { get; set; }
        public string currency { get; set; }
        public bool estimate { get; set; }
        public int minAmount { get; set; }
        public int maxAmount { get; set; }
        public string periodicity { get; set; }
        public bool visible { get; set; }
    }
}
