using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Place
    {
        public bool remote { get; set; }
        public bool anywhere { get; set; }
        public bool timezone { get; set; }
        public List<object> location { get; set; }
    }
}
