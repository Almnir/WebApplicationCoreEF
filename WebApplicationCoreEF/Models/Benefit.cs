using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class Benefit
    {
        public Benefit()
        {
            Application = new HashSet<Application>();
            ApplicationEntranceTestDocument = new HashSet<ApplicationEntranceTestDocument>();
            ApplicationSelectedCompetitiveGroup = new HashSet<ApplicationSelectedCompetitiveGroup>();
            BenefitItemC = new HashSet<BenefitItemC>();
        }

        public short BenefitId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<ApplicationEntranceTestDocument> ApplicationEntranceTestDocument { get; set; }
        public virtual ICollection<ApplicationSelectedCompetitiveGroup> ApplicationSelectedCompetitiveGroup { get; set; }
        public virtual ICollection<BenefitItemC> BenefitItemC { get; set; }
    }
}
