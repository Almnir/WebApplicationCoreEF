using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class EntrantDocument
    {
        public EntrantDocument()
        {
            ApplicationEntranceTestDocument = new HashSet<ApplicationEntranceTestDocument>();
            ApplicationEntrantDocument = new HashSet<ApplicationEntrantDocument>();
            Entrant = new HashSet<Entrant>();
            IndividualAchivement = new HashSet<IndividualAchivement>();
        }

        public int EntrantDocumentId { get; set; }
        public int EntrantId { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentSeries { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentOrganization { get; set; }
        public string DocumentSpecificData { get; set; }
        public int? AttachmentId { get; set; }
        public string Uid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? EntrantDocumentGuid { get; set; }
        public bool? OlympApproved { get; set; }

        public virtual Attachment Attachment { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual Entrant EntrantNavigation { get; set; }
        public virtual ICollection<ApplicationEntranceTestDocument> ApplicationEntranceTestDocument { get; set; }
        public virtual ICollection<ApplicationEntrantDocument> ApplicationEntrantDocument { get; set; }
        public virtual ICollection<Entrant> Entrant { get; set; }
        public virtual ICollection<IndividualAchivement> IndividualAchivement { get; set; }
    }
}
