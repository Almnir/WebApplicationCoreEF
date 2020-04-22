using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class MapInstitutionStructure
    {
        public int NewInstitutionStructureId { get; set; }
        public int? OldInstitutionStructureId { get; set; }
        public string NewUid { get; set; }
        public string OldUid { get; set; }
    }
}
