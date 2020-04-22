using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkApplicationCompetitiveGroupItem
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }
        public int? CompetitiveGroupId { get; set; }
        public int? CompetitiveGroupItemId { get; set; }
        public int? CompetitiveGroupTargetId { get; set; }
        public int EducationForm { get; set; }
        public int EducationSource { get; set; }
        public int? Priority { get; set; }
        public int ImportPackageId { get; set; }
        public int InstitutionId { get; set; }
    }
}
