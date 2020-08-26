using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Data
    {
        public string code { get; set; }
        public string currency { get; set; }
        public double minAmount { get; set; }
        public double? maxAmount { get; set; }
        public string periodicity { get; set; }
    }
}
