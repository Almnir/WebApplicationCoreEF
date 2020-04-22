using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class NormativeVersionState
    {
        public NormativeVersionState()
        {
            NormativeDictionary = new HashSet<NormativeDictionary>();
        }

        public byte VersionStateId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<NormativeDictionary> NormativeDictionary { get; set; }
    }
}
