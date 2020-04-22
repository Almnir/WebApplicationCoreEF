using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class CompetitiveGroupItem
    {
        public CompetitiveGroupItem()
        {
            Application = new HashSet<Application>();
            ApplicationCompetitiveGroupItem = new HashSet<ApplicationCompetitiveGroupItem>();
            ApplicationSelectedCompetitiveGroupItem = new HashSet<ApplicationSelectedCompetitiveGroupItem>();
            CompetitiveGroupTargetItem = new HashSet<CompetitiveGroupTargetItem>();
        }

        public int CompetitiveGroupItemId { get; set; }
        public int CompetitiveGroupId { get; set; }
        public int DirectionId { get; set; }
        public int NumberBudgetO { get; set; }
        public int NumberBudgetOz { get; set; }
        public int NumberBudgetZ { get; set; }
        public int NumberPaidO { get; set; }
        public int NumberPaidOz { get; set; }
        public int NumberPaidZ { get; set; }
        public string Uid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public short EducationLevelId { get; set; }
        public int? NumberQuotaO { get; set; }
        public int? NumberQuotaOz { get; set; }
        public int? NumberQuotaZ { get; set; }

        public virtual CompetitiveGroup CompetitiveGroup { get; set; }
        public virtual Direction Direction { get; set; }
        public virtual AdmissionItemType EducationLevel { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<ApplicationCompetitiveGroupItem> ApplicationCompetitiveGroupItem { get; set; }
        public virtual ICollection<ApplicationSelectedCompetitiveGroupItem> ApplicationSelectedCompetitiveGroupItem { get; set; }
        public virtual ICollection<CompetitiveGroupTargetItem> CompetitiveGroupTargetItem { get; set; }
    }
}
