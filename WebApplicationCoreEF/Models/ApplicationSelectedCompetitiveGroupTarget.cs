using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class ApplicationSelectedCompetitiveGroupTarget
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int CompetitiveGroupTargetId { get; set; }
        public bool IsForO { get; set; }
        public bool IsForOz { get; set; }
        public bool IsForZ { get; set; }

        public virtual Application Application { get; set; }
        public virtual CompetitiveGroupTarget CompetitiveGroupTarget { get; set; }
    }
}
