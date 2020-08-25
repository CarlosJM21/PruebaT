using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Bio
    {
        public PersonB person { get; set; }
        public Stats stats { get; set; }
        public List<StrengthB> strengths { get; set; }
        public List<Interest> interests { get; set; }
        public List<Experience> experiences { get; set; }
        public List<OpportunityB> opportunities { get; set; }
        public List<LanguageB> languages { get; set; }
        public ProfessionalCultureGenomeResults professionalCultureGenomeResults { get; set; }
    }
}
