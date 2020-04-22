using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class OlympicDiplomType
    {
        public OlympicDiplomType()
        {
            BenefitItemC = new HashSet<BenefitItemC>();
        }

        public short OlympicDiplomTypeId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<BenefitItemC> BenefitItemC { get; set; }
    }
}
