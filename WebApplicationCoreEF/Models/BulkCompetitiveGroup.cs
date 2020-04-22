using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkCompetitiveGroup
    {
        public int? Id { get; set; }
        public Guid Guid { get; set; }
        public int InstitutionId { get; set; }
        public int ImportPackageId { get; set; }
        public string Name { get; set; }
        public short Course { get; set; }
        public string Uid { get; set; }
        public int? CampaignId { get; set; }
        public int DirectionFilterType { get; set; }
    }
}
