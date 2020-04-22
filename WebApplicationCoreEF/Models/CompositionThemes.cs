using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class CompositionThemes
    {
        public CompositionThemes()
        {
            ApplicationCompositionResults = new HashSet<ApplicationCompositionResults>();
        }

        public int ThemeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApplicationCompositionResults> ApplicationCompositionResults { get; set; }
    }
}
