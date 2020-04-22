using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class AdmissionItemType
    {
        public AdmissionItemType()
        {
            AdmissionVolume = new HashSet<AdmissionVolume>();
            AllowedDirections = new HashSet<AllowedDirections>();
            ApplicationConsidered = new HashSet<ApplicationConsidered>();
            ApplicationOrderEducationForm = new HashSet<Application>();
            ApplicationOrderEducationSource = new HashSet<Application>();
            CampaignDateEducationForm = new HashSet<CampaignDate>();
            CampaignDateEducationLevel = new HashSet<CampaignDate>();
            CampaignDateEducationSource = new HashSet<CampaignDate>();
            CampaignEducationLevel = new HashSet<CampaignEducationLevel>();
            CompetitiveGroupItem = new HashSet<CompetitiveGroupItem>();
            EduLevels = new HashSet<EduLevels>();
            OrderOfAdmissionEducationForm = new HashSet<OrderOfAdmission>();
            OrderOfAdmissionEducationLevel = new HashSet<OrderOfAdmission>();
            OrderOfAdmissionEducationSource = new HashSet<OrderOfAdmission>();
        }

        public short ItemTypeId { get; set; }
        public string Name { get; set; }
        public short ItemLevel { get; set; }
        public bool CanBeSkipped { get; set; }
        public bool AutoCopyName { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<AdmissionVolume> AdmissionVolume { get; set; }
        public virtual ICollection<AllowedDirections> AllowedDirections { get; set; }
        public virtual ICollection<ApplicationConsidered> ApplicationConsidered { get; set; }
        public virtual ICollection<Application> ApplicationOrderEducationForm { get; set; }
        public virtual ICollection<Application> ApplicationOrderEducationSource { get; set; }
        public virtual ICollection<CampaignDate> CampaignDateEducationForm { get; set; }
        public virtual ICollection<CampaignDate> CampaignDateEducationLevel { get; set; }
        public virtual ICollection<CampaignDate> CampaignDateEducationSource { get; set; }
        public virtual ICollection<CampaignEducationLevel> CampaignEducationLevel { get; set; }
        public virtual ICollection<CompetitiveGroupItem> CompetitiveGroupItem { get; set; }
        public virtual ICollection<EduLevels> EduLevels { get; set; }
        public virtual ICollection<OrderOfAdmission> OrderOfAdmissionEducationForm { get; set; }
        public virtual ICollection<OrderOfAdmission> OrderOfAdmissionEducationLevel { get; set; }
        public virtual ICollection<OrderOfAdmission> OrderOfAdmissionEducationSource { get; set; }
    }
}
