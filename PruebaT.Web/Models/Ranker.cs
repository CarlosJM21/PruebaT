using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Ranker
    {
        public string @type { get; set; }
        public double rank { get; set; }
        public object score { get; set; }
        public List<And> and { get; set; }
    }
}
