using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Member
    {
        public string id { get; set; }
        public Person person { get; set; }
        public bool manager { get; set; }
        public bool poster { get; set; }
        public bool member { get; set; }
        public string status { get; set; }
        public bool visible { get; set; }
        public bool screeningQuestionsTipClosed { get; set; }
    }
}
