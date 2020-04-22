using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class EntrantDocumentEgeAndOlympicSubject
    {
        public int EntrantDocumentId { get; set; }
        public int? SubjectId { get; set; }
        public decimal? Value { get; set; }
        public int? AppealStatusId { get; set; }

        public virtual AppealStatus AppealStatus { get; set; }
        public virtual EntrantDocument EntrantDocument { get; set; }
    }
}
