using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class Attachment
    {
        public Attachment()
        {
            EntrantDocument = new HashSet<EntrantDocument>();
            Institution = new HashSet<Institution>();
            InstitutionAccreditation = new HashSet<InstitutionAccreditation>();
            InstitutionHistoryAccreditationAttachment = new HashSet<InstitutionHistory>();
            InstitutionHistoryHostelAttachment = new HashSet<InstitutionHistory>();
            InstitutionHistoryLicenseAttachment = new HashSet<InstitutionHistory>();
            InstitutionLicense = new HashSet<InstitutionLicense>();
            PreparatoryCourse = new HashSet<PreparatoryCourse>();
        }

        public int AttachmentId { get; set; }
        public string MimeType { get; set; }
        public string Name { get; set; }
        public byte[] Body { get; set; }
        public Guid FileId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<EntrantDocument> EntrantDocument { get; set; }
        public virtual ICollection<Institution> Institution { get; set; }
        public virtual ICollection<InstitutionAccreditation> InstitutionAccreditation { get; set; }
        public virtual ICollection<InstitutionHistory> InstitutionHistoryAccreditationAttachment { get; set; }
        public virtual ICollection<InstitutionHistory> InstitutionHistoryHostelAttachment { get; set; }
        public virtual ICollection<InstitutionHistory> InstitutionHistoryLicenseAttachment { get; set; }
        public virtual ICollection<InstitutionLicense> InstitutionLicense { get; set; }
        public virtual ICollection<PreparatoryCourse> PreparatoryCourse { get; set; }
    }
}
