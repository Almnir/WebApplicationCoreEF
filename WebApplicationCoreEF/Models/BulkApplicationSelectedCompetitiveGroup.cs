﻿using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkApplicationSelectedCompetitiveGroup
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Uid { get; set; }
        public int CompetitiveGroupId { get; set; }
        public decimal? CalculatedRating { get; set; }
        public int? CalculatedBenefitId { get; set; }
        public int ImportPackageId { get; set; }
        public int InstitutionId { get; set; }
    }
}
