using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Opportunity
    {
        public List<Attachment> attachments { get; set; }
        public int boardVersion { get; set; }
        public PrefilledStatus prefilledStatus { get; set; }
        public string locale { get; set; }
        public string objective { get; set; }
        public string review { get; set; }
        public object draft { get; set; }
        public List<Member> members { get; set; }
        public List<Detail> details { get; set; }
        public string id { get; set; }
        public Place place { get; set; }
        public DateTime deadline { get; set; }
        public string slug { get; set; }
        public Owner owner { get; set; }
        public double completion { get; set; }
        public Agreement agreement { get; set; }
        public List<Language> languages { get; set; }
        public DateTime created { get; set; }
        public string opportunity { get; set; }
        public bool active { get; set; }
        public Commitment commitment { get; set; }
        public DateTime stableOn { get; set; }
        public List<string> timezones { get; set; }
        public List<Strength> strengths { get; set; }
        public List<Organization> organizations { get; set; }
        public Compensation compensation { get; set; }
        public string openGraph { get; set; }
        public string status { get; set; }
    }
}
