using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BenefitItemSubject
    {
        public int Id { get; set; }
        public int BenefitItemId { get; set; }
        public int SubjectId { get; set; }
        public int EgeMinValue { get; set; }

        public virtual BenefitItemC BenefitItem { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
