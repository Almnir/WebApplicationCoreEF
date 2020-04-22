using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class CompetitiveGroupTargetItem
    {
        public int CompetitiveGroupTargetItemId { get; set; }
        public int CompetitiveGroupTargetId { get; set; }
        public int CompetitiveGroupItemId { get; set; }
        public string Uid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int NumberTargetO { get; set; }
        public int NumberTargetOz { get; set; }
        public int NumberTargetZ { get; set; }

        public virtual CompetitiveGroupItem CompetitiveGroupItem { get; set; }
        public virtual CompetitiveGroupTarget CompetitiveGroupTarget { get; set; }
    }
}
