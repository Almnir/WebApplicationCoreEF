using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class CompetitiveGroup
    {
        public CompetitiveGroup()
        {
            Application = new HashSet<Application>();
            ApplicationCompetitiveGroupItem = new HashSet<ApplicationCompetitiveGroupItem>();
            ApplicationEntranceTestDocument = new HashSet<ApplicationEntranceTestDocument>();
            ApplicationSelectedCompetitiveGroup = new HashSet<ApplicationSelectedCompetitiveGroup>();
            BenefitItemC = new HashSet<BenefitItemC>();
            CompetitiveGroupItem = new HashSet<CompetitiveGroupItem>();
            EntranceTestItemC = new HashSet<EntranceTestItemC>();
            RecomendedLists = new HashSet<RecomendedLists>();
        }

        public int CompetitiveGroupId { get; set; }
        public int InstitutionId { get; set; }
        public string Name { get; set; }
        public short Course { get; set; }
        public string Uid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CampaignId { get; set; }
        public int DirectionFilterType { get; set; }
        public Guid? CompetitiveGroupGuid { get; set; }

        public virtual Campaign Campaign { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<ApplicationCompetitiveGroupItem> ApplicationCompetitiveGroupItem { get; set; }
        public virtual ICollection<ApplicationEntranceTestDocument> ApplicationEntranceTestDocument { get; set; }
        public virtual ICollection<ApplicationSelectedCompetitiveGroup> ApplicationSelectedCompetitiveGroup { get; set; }
        public virtual ICollection<BenefitItemC> BenefitItemC { get; set; }
        public virtual ICollection<CompetitiveGroupItem> CompetitiveGroupItem { get; set; }
        public virtual ICollection<EntranceTestItemC> EntranceTestItemC { get; set; }
        public virtual ICollection<RecomendedLists> RecomendedLists { get; set; }
    }
}
