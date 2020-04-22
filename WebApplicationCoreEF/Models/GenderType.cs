using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class GenderType
    {
        public GenderType()
        {
            Entrant = new HashSet<Entrant>();
        }

        public int GenderId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Entrant> Entrant { get; set; }
    }
}
