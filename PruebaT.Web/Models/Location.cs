using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Location
    {
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string timezone { get; set; }
        public int timezoneOffSet { get; set; }
    }
}
