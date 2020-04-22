using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class AllowedDirections
    {
        public int InstitutionId { get; set; }
        public int DirectionId { get; set; }
        public short AdmissionItemTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual AdmissionItemType AdmissionItemType { get; set; }
        public virtual Direction Direction { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
