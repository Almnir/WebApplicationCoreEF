using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class CampaignEducationLevel
    {
        public int CampaignEducationLevelId { get; set; }
        public int CampaignId { get; set; }
        public int Course { get; set; }
        public short EducationLevelId { get; set; }

        public virtual Campaign Campaign { get; set; }
        public virtual AdmissionItemType EducationLevel { get; set; }
    }
}
