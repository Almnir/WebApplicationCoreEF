using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class MapDirections
    {
        public int NewDirectionId { get; set; }
        public int? OldDirectionId { get; set; }
        public string NewUid { get; set; }
        public string OldUid { get; set; }
    }
}
