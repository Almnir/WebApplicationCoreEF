using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkApplicationSelectedCompetitiveGroupItem
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public int CompetitiveGroupItemId { get; set; }
        public int ImportPackageId { get; set; }
        public int InstitutionId { get; set; }
    }
}
