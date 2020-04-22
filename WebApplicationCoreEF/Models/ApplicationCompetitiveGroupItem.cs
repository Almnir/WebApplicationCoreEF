using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class ApplicationCompetitiveGroupItem
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int CompetitiveGroupId { get; set; }
        public int CompetitiveGroupItemId { get; set; }
        public int EducationFormId { get; set; }
        public int EducationSourceId { get; set; }
        public int? Priority { get; set; }
        public int? CompetitiveGroupTargetId { get; set; }

        public virtual Application Application { get; set; }
        public virtual CompetitiveGroup CompetitiveGroup { get; set; }
        public virtual CompetitiveGroupItem CompetitiveGroupItem { get; set; }
    }
}
