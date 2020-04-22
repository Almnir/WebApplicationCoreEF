using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class EntranceTestItemC
    {
        public EntranceTestItemC()
        {
            ApplicationEntranceTestDocument = new HashSet<ApplicationEntranceTestDocument>();
            BenefitItemC = new HashSet<BenefitItemC>();
        }

        public int EntranceTestItemId { get; set; }
        public int CompetitiveGroupId { get; set; }
        public short EntranceTestTypeId { get; set; }
        public string Form { get; set; }
        public decimal? MinScore { get; set; }
        public int? SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Uid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? EntranceTestPriority { get; set; }
        public Guid? EntranceTestItemGuid { get; set; }

        public virtual CompetitiveGroup CompetitiveGroup { get; set; }
        public virtual EntranceTestType EntranceTestType { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<ApplicationEntranceTestDocument> ApplicationEntranceTestDocument { get; set; }
        public virtual ICollection<BenefitItemC> BenefitItemC { get; set; }
    }
}
