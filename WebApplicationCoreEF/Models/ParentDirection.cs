using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class ParentDirection
    {
        public ParentDirection()
        {
            Direction = new HashSet<Direction>();
        }

        public int ParentDirectionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Direction> Direction { get; set; }
    }
}
