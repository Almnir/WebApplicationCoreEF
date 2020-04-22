using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class EntrantDocumentOlympic
    {
        public int EntrantDocumentId { get; set; }
        public int? DiplomaTypeId { get; set; }
        public int? OlympicId { get; set; }

        public virtual EntrantDocument EntrantDocument { get; set; }
    }
}
