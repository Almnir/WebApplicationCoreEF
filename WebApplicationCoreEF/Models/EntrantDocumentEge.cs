using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class EntrantDocumentEge
    {
        public int EntrantDocumentId { get; set; }
        public string DecisionNumber { get; set; }
        public string Decision { get; set; }
        public DateTime? DecisionDate { get; set; }
        public string TypographicNumber { get; set; }

        public virtual EntrantDocument EntrantDocument { get; set; }
    }
}
