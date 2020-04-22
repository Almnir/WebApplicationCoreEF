using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class OlympicType
    {
        public OlympicType()
        {
            BenefitItemColympicType = new HashSet<BenefitItemColympicType>();
            OlympicTypeSubjectLink = new HashSet<OlympicTypeSubjectLink>();
        }

        public int OlympicId { get; set; }
        public string Name { get; set; }
        public short? OlympicLevelId { get; set; }
        public string OrganizerName { get; set; }
        public int OlympicNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int OlympicYear { get; set; }

        public virtual OlympicLevel OlympicLevel { get; set; }
        public virtual ICollection<BenefitItemColympicType> BenefitItemColympicType { get; set; }
        public virtual ICollection<OlympicTypeSubjectLink> OlympicTypeSubjectLink { get; set; }
    }
}
