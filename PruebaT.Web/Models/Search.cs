using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Search<T> where T : class
    {

        public aggregators aggregators { get; set; }

        public int offset { get; set; }

        public IEnumerable<T> Results { get; set; }

        public int size { get; set; }

        public int total { get; set; }

    }
}
