using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class SPerson
    {
        public Context context { get; set; }
        public Meta _meta { get; set; }
        public Compensations compensations { get; set; }
        public string locationName { get; set; }
        public string name { get; set; }
        public List<string> openTo { get; set; }
        public string picture { get; set; }
        public string professionalHeadline { get; set; }
        public bool remoter { get; set; }
        public List<Skill> skills { get; set; }
        public string subjectId { get; set; }
        public string username { get; set; }
        public bool verified { get; set; }
        public double weight { get; set; }
    }
}
