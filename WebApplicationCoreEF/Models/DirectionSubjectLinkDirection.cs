using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class DirectionSubjectLinkDirection
    {
        public int Id { get; set; }
        public int DirectionId { get; set; }
        public int LinkId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Direction Direction { get; set; }
        public virtual DirectionSubjectLink Link { get; set; }
    }
}
