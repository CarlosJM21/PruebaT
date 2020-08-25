using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Experience
    {
        public string id { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public List<Organization> organizations { get; set; }
        public List<object> responsibilities { get; set; }
        public string fromMonth { get; set; }
        public string fromYear { get; set; }
        public bool remote { get; set; }
        public string additionalInfo { get; set; }
        public bool highlighted { get; set; }
        public double weight { get; set; }
        public int verifications { get; set; }
        public int recommendations { get; set; }
        public List<Medium> media { get; set; }
        public string contributions { get; set; }
        public string toMonth { get; set; }
        public string toYear { get; set; }
    }
}
