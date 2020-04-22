using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            EduLevelDocumentType = new HashSet<EduLevelDocumentType>();
            EntrantDocument = new HashSet<EntrantDocument>();
        }

        public int DocumentId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CategoryId { get; set; }
        public bool IsMedical { get; set; }

        public virtual DocumentCategory Category { get; set; }
        public virtual ICollection<EduLevelDocumentType> EduLevelDocumentType { get; set; }
        public virtual ICollection<EntrantDocument> EntrantDocument { get; set; }
    }
}
