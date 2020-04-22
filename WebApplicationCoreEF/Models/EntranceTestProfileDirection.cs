using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class EntranceTestProfileDirection
    {
        public int ProfileDirectionId { get; set; }
        public int InstitutionId { get; set; }
        public int DirectionId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Direction Direction { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
