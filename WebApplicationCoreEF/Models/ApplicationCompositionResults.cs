using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class ApplicationCompositionResults
    {
        public int CompositionId { get; set; }
        public int ApplicationId { get; set; }
        public string SourceId { get; set; }
        public DateTime Year { get; set; }
        public int? ThemeId { get; set; }
        public bool Result { get; set; }

        public virtual Application Application { get; set; }
        public virtual CompositionThemes Theme { get; set; }
    }
}
