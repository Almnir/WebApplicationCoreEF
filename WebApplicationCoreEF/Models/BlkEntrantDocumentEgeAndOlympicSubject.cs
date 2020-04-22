using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BlkEntrantDocumentEgeAndOlympicSubject
    {
        public int? SubjectId { get; set; }
        public decimal? Value { get; set; }
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Uid { get; set; }
        public int ImportPackageId { get; set; }
        public int InstitutionId { get; set; }
    }
}
