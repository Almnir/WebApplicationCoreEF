using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class Campaign
    {
        public Campaign()
        {
            AdmissionVolume = new HashSet<AdmissionVolume>();
            CampaignDate = new HashSet<CampaignDate>();
            CampaignEducationLevel = new HashSet<CampaignEducationLevel>();
            CompetitiveGroup = new HashSet<CompetitiveGroup>();
            InstitutionAchievements = new HashSet<InstitutionAchievements>();
            OrderOfAdmission = new HashSet<OrderOfAdmission>();
            RecomendedLists = new HashSet<RecomendedLists>();
        }

        public int CampaignId { get; set; }
        public int InstitutionId { get; set; }
        public string Name { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set; }
        public int EducationFormFlag { get; set; }
        public int StatusId { get; set; }
        public string Uid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool Additional { get; set; }
        public bool IsFromKrym { get; set; }
        public Guid? CampaignGuid { get; set; }

        public virtual Institution Institution { get; set; }
        public virtual ICollection<AdmissionVolume> AdmissionVolume { get; set; }
        public virtual ICollection<CampaignDate> CampaignDate { get; set; }
        public virtual ICollection<CampaignEducationLevel> CampaignEducationLevel { get; set; }
        public virtual ICollection<CompetitiveGroup> CompetitiveGroup { get; set; }
        public virtual ICollection<InstitutionAchievements> InstitutionAchievements { get; set; }
        public virtual ICollection<OrderOfAdmission> OrderOfAdmission { get; set; }
        public virtual ICollection<RecomendedLists> RecomendedLists { get; set; }
    }
}
