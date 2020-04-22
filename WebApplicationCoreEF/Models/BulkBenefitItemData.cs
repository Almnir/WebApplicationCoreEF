using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkBenefitItemData
    {
        public Guid Guid { get; set; }
        public Guid ParentId { get; set; }
        public int InstitutionId { get; set; }
        public int ImportPackageId { get; set; }
        public int? OlympicTypeId { get; set; }
        public int? SubjectId { get; set; }
        public int? EgeMinValue { get; set; }
    }
}
