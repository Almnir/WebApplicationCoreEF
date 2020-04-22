using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class MapCompetitiveGroupTargetItem
    {
        public int NewCompetitiveGroupTargetItemId { get; set; }
        public int? OldCompetitiveGroupTargetItemId { get; set; }
        public string NewUid { get; set; }
        public string OldUid { get; set; }
    }
}
