using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class EntrantDocumentDisability
    {
        public int EntrantDocumentId { get; set; }
        public int? DisabilityTypeId { get; set; }

        public virtual EntrantDocument EntrantDocument { get; set; }
    }
}
