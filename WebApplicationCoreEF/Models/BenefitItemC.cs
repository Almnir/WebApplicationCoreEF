using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BenefitItemC
    {
        public BenefitItemC()
        {
            BenefitItemColympicType = new HashSet<BenefitItemColympicType>();
            BenefitItemSubject = new HashSet<BenefitItemSubject>();
        }

        public int BenefitItemId { get; set; }
        public int? EntranceTestItemId { get; set; }
        public short OlympicDiplomTypeId { get; set; }
        public short OlympicLevelFlags { get; set; }
        public short BenefitId { get; set; }
        public bool IsForAllOlympic { get; set; }
        public bool IsProfileSubject { get; set; }
        public int CompetitiveGroupId { get; set; }
        public string Uid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int OlympicYear { get; set; }
        public int? EgeMinValue { get; set; }
        public Guid? BenefitItemGuid { get; set; }

        public virtual Benefit Benefit { get; set; }
        public virtual CompetitiveGroup CompetitiveGroup { get; set; }
        public virtual EntranceTestItemC EntranceTestItem { get; set; }
        public virtual OlympicDiplomType OlympicDiplomType { get; set; }
        public virtual ICollection<BenefitItemColympicType> BenefitItemColympicType { get; set; }
        public virtual ICollection<BenefitItemSubject> BenefitItemSubject { get; set; }
    }
}
