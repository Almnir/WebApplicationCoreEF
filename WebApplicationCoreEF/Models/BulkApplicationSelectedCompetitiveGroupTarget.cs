﻿using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkApplicationSelectedCompetitiveGroupTarget
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public int CompetitiveGroupTargetId { get; set; }
        public bool IsForO { get; set; }
        public bool IsForOz { get; set; }
        public bool IsForZ { get; set; }
        public int ImportPackageId { get; set; }
        public int InstitutionId { get; set; }
    }
}
