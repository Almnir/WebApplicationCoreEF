using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class Entrant
    {
        public Entrant()
        {
            Application = new HashSet<Application>();
            EntrantDocument = new HashSet<EntrantDocument>();
            EntrantLanguage = new HashSet<EntrantLanguage>();
        }

        public int EntrantId { get; set; }
        public int? IdentityDocumentId { get; set; }
        public string CustomInformation { get; set; }
        public string Snils { get; set; }
        public int? RegistrationAddressId { get; set; }
        public int? FactAddressId { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Uid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? InstitutionId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int GenderId { get; set; }
        public int? PersonId { get; set; }
        public DateTime? PersonLinkDate { get; set; }
        public Guid? EntrantGuid { get; set; }

        public virtual Address FactAddress { get; set; }
        public virtual GenderType Gender { get; set; }
        public virtual EntrantDocument IdentityDocument { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual Rvipersons Person { get; set; }
        public virtual Address RegistrationAddress { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<EntrantDocument> EntrantDocument { get; set; }
        public virtual ICollection<EntrantLanguage> EntrantLanguage { get; set; }
    }
}
