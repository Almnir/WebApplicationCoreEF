using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class EntrantDocumentEdu
    {
        public int EntrantDocumentId { get; set; }
        public string RegistrationNumber { get; set; }
        public string InstitutionName { get; set; }
        public string SpecialityName { get; set; }
        public string QualificationName { get; set; }
        public float? Gpa { get; set; }

        public virtual EntrantDocument EntrantDocument { get; set; }
    }
}
