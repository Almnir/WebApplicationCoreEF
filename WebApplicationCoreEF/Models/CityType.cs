using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class CityType
    {
        public int CityId { get; set; }
        public int RegionId { get; set; }
        public string Name { get; set; }
        public string OkatoCode { get; set; }
        public DateTime? OkatoModified { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
