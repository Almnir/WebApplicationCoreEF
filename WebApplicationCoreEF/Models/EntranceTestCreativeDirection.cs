using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class EntranceTestCreativeDirection
    {
        public int DirectionId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Direction Direction { get; set; }
    }
}
