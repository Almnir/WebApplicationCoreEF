using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class ApplicationSelectedCompetitiveGroup
    {
        public int ItemId { get; set; }
        public int ApplicationId { get; set; }
        public int CompetitiveGroupId { get; set; }
        public short? CalculatedBenefitId { get; set; }
        public decimal? CalculatedRating { get; set; }

        public virtual Application Application { get; set; }
        public virtual Benefit CalculatedBenefit { get; set; }
        public virtual CompetitiveGroup CompetitiveGroup { get; set; }
    }
}
