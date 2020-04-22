using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class MapAdmissionVolume
    {
        public int NewAdmissionVolumeId { get; set; }
        public int? OldAdmissionVolumeId { get; set; }
        public string NewUid { get; set; }
        public string OldUid { get; set; }
    }
}
