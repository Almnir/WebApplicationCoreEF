using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class EntrantDocumentCustom
    {
        public int EntrantDocumentId { get; set; }
        public string DocumentTypeNameText { get; set; }
        public string AdditionalInfo { get; set; }

        public virtual EntrantDocument EntrantDocument { get; set; }
    }
}
