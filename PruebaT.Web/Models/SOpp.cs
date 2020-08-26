using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class SOpp
    {
        public string id { get; set; }
        public string objective { get; set; }
        public string type { get; set; }
        public List<Organization> organizations { get; set; }
        public List<string> locations { get; set; }
        public bool remote { get; set; }
        public bool external { get; set; }
        public DateTime? deadline { get; set; }
        public string status { get; set; }
        public CompensationO compensation { get; set; }
        public List<Skill> skills { get; set; }
        public List<MemberO> members { get; set; }
        public List<Question> questions { get; set; }
        public Context context { get; set; }
        public MetaO _meta { get; set; }
    }
}
