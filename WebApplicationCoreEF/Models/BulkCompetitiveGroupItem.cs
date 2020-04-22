using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkCompetitiveGroupItem
    {
        public int? Id { get; set; }
        public Guid Guid { get; set; }
        public Guid ParentId { get; set; }
        public int InstitutionId { get; set; }
        public int ImportPackageId { get; set; }
        public int DirectionId { get; set; }
        public int NumberBudgetO { get; set; }
        public int NumberBudgetOz { get; set; }
        public int NumberBudgetZ { get; set; }
        public int NumberPaidO { get; set; }
        public int NumberPaidOz { get; set; }
        public int NumberPaidZ { get; set; }
        public string Uid { get; set; }
        public short EducationLevelId { get; set; }
        public int? NumberQuotaO { get; set; }
        public int? NumberQuotaOz { get; set; }
        public int? NumberQuotaZ { get; set; }
    }
}
