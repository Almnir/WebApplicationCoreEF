using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class DirectionSubjectLinkSubject
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int LinkId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual DirectionSubjectLink Link { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
