using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Interest
    {
        public string id { get; set; }
        public int code { get; set; }
        public string name { get; set; }
        public List<object> media { get; set; }
        public DateTime created { get; set; }
    }
}
