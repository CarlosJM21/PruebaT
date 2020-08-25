using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Person
    {
        public string id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public bool hasEmail { get; set; }
        public bool hasBio { get; set; }
        public double bioCompletion { get; set; }
        public int weight { get; set; }
        public bool verified { get; set; }
        public string professionalHeadline { get; set; }
        public int? subjectId { get; set; }
    }
}
