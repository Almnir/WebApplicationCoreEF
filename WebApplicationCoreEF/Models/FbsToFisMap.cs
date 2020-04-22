using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class FbsToFisMap
    {
        public int Id { get; set; }
        public int IdSubjectFis { get; set; }
        public int IdSubjectFbs { get; set; }

        public virtual Subject IdSubjectFisNavigation { get; set; }
    }
}
