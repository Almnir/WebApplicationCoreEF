using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class Institution
    {
        public Institution()
        {
            AdmissionVolume = new HashSet<AdmissionVolume>();
            AllowedDirections = new HashSet<AllowedDirections>();
            Application = new HashSet<Application>();
            Campaign = new HashSet<Campaign>();
            CompetitiveGroup = new HashSet<CompetitiveGroup>();
            CompetitiveGroupTarget = new HashSet<CompetitiveGroupTarget>();
            EntranceTestProfileDirection = new HashSet<EntranceTestProfileDirection>();
            Entrant = new HashSet<Entrant>();
            ImportPackage = new HashSet<ImportPackage>();
            InstitutionAccreditation = new HashSet<InstitutionAccreditation>();
            InstitutionItem = new HashSet<InstitutionItem>();
            InstitutionLicense = new HashSet<InstitutionLicense>();
            OrderOfAdmission = new HashSet<OrderOfAdmission>();
            PreparatoryCourse = new HashSet<PreparatoryCourse>();
            RecomendedLists = new HashSet<RecomendedLists>();
            RequestDirection = new HashSet<RequestDirection>();
            UserPolicy = new HashSet<UserPolicy>();
        }

        public int InstitutionId { get; set; }
        public short InstitutionTypeId { get; set; }
        public string FullName { get; set; }
        public string BriefName { get; set; }
        public int? FormOfLawId { get; set; }
        public int? RegionId { get; set; }
        public string Site { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool HasMilitaryDepartment { get; set; }
        public bool HasHostel { get; set; }
        public int? HostelCapacity { get; set; }
        public bool HasHostelForEntrants { get; set; }
        public int? HostelAttachmentId { get; set; }
        public string Inn { get; set; }
        public string Ogrn { get; set; }
        public DateTime? AdmissionStructurePublishDate { get; set; }
        public DateTime? ReceivingApplicationDate { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? EsrpOrgId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string OwnerDepartment { get; set; }
        public int? MainEsrpOrgId { get; set; }
        public int? FounderEsrpOrgId { get; set; }
        public int? StatusId { get; set; }

        public virtual FormOfLaw FormOfLaw { get; set; }
        public virtual Attachment HostelAttachment { get; set; }
        public virtual InstitutionType InstitutionType { get; set; }
        public virtual RegionType Region { get; set; }
        public virtual ICollection<AdmissionVolume> AdmissionVolume { get; set; }
        public virtual ICollection<AllowedDirections> AllowedDirections { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<Campaign> Campaign { get; set; }
        public virtual ICollection<CompetitiveGroup> CompetitiveGroup { get; set; }
        public virtual ICollection<CompetitiveGroupTarget> CompetitiveGroupTarget { get; set; }
        public virtual ICollection<EntranceTestProfileDirection> EntranceTestProfileDirection { get; set; }
        public virtual ICollection<Entrant> Entrant { get; set; }
        public virtual ICollection<ImportPackage> ImportPackage { get; set; }
        public virtual ICollection<InstitutionAccreditation> InstitutionAccreditation { get; set; }
        public virtual ICollection<InstitutionItem> InstitutionItem { get; set; }
        public virtual ICollection<InstitutionLicense> InstitutionLicense { get; set; }
        public virtual ICollection<OrderOfAdmission> OrderOfAdmission { get; set; }
        public virtual ICollection<PreparatoryCourse> PreparatoryCourse { get; set; }
        public virtual ICollection<RecomendedLists> RecomendedLists { get; set; }
        public virtual ICollection<RequestDirection> RequestDirection { get; set; }
        public virtual ICollection<UserPolicy> UserPolicy { get; set; }
    }
}
