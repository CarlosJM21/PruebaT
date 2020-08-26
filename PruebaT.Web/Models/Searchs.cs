using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Searchs
    {
        public Search<SPerson> People { get; set; }

        public Search<SOpp> Jobs { get; set; }
    }
}
