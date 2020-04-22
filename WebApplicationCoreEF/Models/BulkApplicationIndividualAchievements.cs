using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkApplicationIndividualAchievements
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public int ImportPackageId { get; set; }
        public int InstitutionId { get; set; }
        public string Iauid { get; set; }
        public string Ianame { get; set; }
        public decimal? Iamark { get; set; }
        public string EntrantDocumentUid { get; set; }
        public int? EntrantDocumentId { get; set; }
        public int? InstitutionArchievementId { get; set; }
    }
}
