using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class OlympicTypeSubjectLink
    {
        public int Id { get; set; }
        public int OlympicId { get; set; }
        public int SubjectId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public short? SubjectLevelId { get; set; }

        public virtual OlympicType Olympic { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual OlympicLevel SubjectLevel { get; set; }
    }
}
