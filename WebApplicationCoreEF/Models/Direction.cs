using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class Direction
    {
        public Direction()
        {
            AdmissionVolume = new HashSet<AdmissionVolume>();
            AllowedDirections = new HashSet<AllowedDirections>();
            ApplicationConsidered = new HashSet<ApplicationConsidered>();
            CompetitiveGroupItem = new HashSet<CompetitiveGroupItem>();
            EntranceTestProfileDirection = new HashSet<EntranceTestProfileDirection>();
            InstitutionItem = new HashSet<InstitutionItem>();
            RecomendedLists = new HashSet<RecomendedLists>();
        }

        public int DirectionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string SysGuid { get; set; }
        public string Edulevel { get; set; }
        public string Eduprogramtype { get; set; }
        public string Ugscode { get; set; }
        public string Ugsname { get; set; }
        public string Qualificationcode { get; set; }
        public string Qualificationname { get; set; }
        public string Period { get; set; }
        public string EduDirectory { get; set; }
        public string EduprAdditional { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string NewCode { get; set; }

        public virtual ParentDirection Parent { get; set; }
        public virtual DirectionSubjectLinkDirection DirectionSubjectLinkDirection { get; set; }
        public virtual EntranceTestCreativeDirection EntranceTestCreativeDirection { get; set; }
        public virtual ICollection<AdmissionVolume> AdmissionVolume { get; set; }
        public virtual ICollection<AllowedDirections> AllowedDirections { get; set; }
        public virtual ICollection<ApplicationConsidered> ApplicationConsidered { get; set; }
        public virtual ICollection<CompetitiveGroupItem> CompetitiveGroupItem { get; set; }
        public virtual ICollection<EntranceTestProfileDirection> EntranceTestProfileDirection { get; set; }
        public virtual ICollection<InstitutionItem> InstitutionItem { get; set; }
        public virtual ICollection<RecomendedLists> RecomendedLists { get; set; }
    }
}
