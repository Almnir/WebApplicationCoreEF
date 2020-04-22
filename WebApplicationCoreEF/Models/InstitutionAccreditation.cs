using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class InstitutionAccreditation
    {
        public int AccreditationId { get; set; }
        public int InstitutionId { get; set; }
        public string Accreditation { get; set; }
        public int? AttachmentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Attachment Attachment { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
