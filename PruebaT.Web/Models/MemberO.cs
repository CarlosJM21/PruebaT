using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class MemberO
    {
        public string subjectId { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string professionalHeadline { get; set; }
        public string picture { get; set; }
        public bool member { get; set; }
        public bool manager { get; set; }
        public bool poster { get; set; }
        public double weight { get; set; }
    }
}
