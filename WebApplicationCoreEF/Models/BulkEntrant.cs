using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkEntrant
    {
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
        public int InstitutionId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int GenderId { get; set; }
        public int ImportPackageId { get; set; }
        public Guid EntrantGuid { get; set; }
    }
}
