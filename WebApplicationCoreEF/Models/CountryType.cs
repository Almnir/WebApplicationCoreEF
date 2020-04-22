using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class CountryType
    {
        public CountryType()
        {
            Address = new HashSet<Address>();
            RegionType = new HashSet<RegionType>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public bool HasRegions { get; set; }
        public string DigitCode { get; set; }
        public string Alfa2Code { get; set; }
        public string Alfa3Code { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<RegionType> RegionType { get; set; }
    }
}
