using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class MetaO
    {
        public double rank { get; set; }
        public object scorer { get; set; }
        public object filter { get; set; }
        public List<string> boosters { get; set; }
    }
}
