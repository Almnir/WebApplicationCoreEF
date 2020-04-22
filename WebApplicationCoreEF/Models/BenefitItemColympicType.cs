using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BenefitItemColympicType
    {
        public int Id { get; set; }
        public int BenefitItemId { get; set; }
        public int OlympicTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual BenefitItemC BenefitItem { get; set; }
        public virtual OlympicType OlympicType { get; set; }
    }
}
