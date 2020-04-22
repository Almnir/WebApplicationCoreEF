using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class OlympicLevel
    {
        public OlympicLevel()
        {
            OlympicType = new HashSet<OlympicType>();
            OlympicTypeSubjectLink = new HashSet<OlympicTypeSubjectLink>();
        }

        public short OlympicLevelId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<OlympicType> OlympicType { get; set; }
        public virtual ICollection<OlympicTypeSubjectLink> OlympicTypeSubjectLink { get; set; }
    }
}
