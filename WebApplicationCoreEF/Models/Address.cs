using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class Address
    {
        public Address()
        {
            EntrantFactAddress = new HashSet<Entrant>();
            EntrantRegistrationAddress = new HashSet<Entrant>();
        }

        public int AddressId { get; set; }
        public int? CountryId { get; set; }
        public int? RegionId { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string BuildingPart { get; set; }
        public string Room { get; set; }
        public string Phone { get; set; }
        public string RegionName { get; set; }
        public string CountryName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual CountryType Country { get; set; }
        public virtual RegionType Region { get; set; }
        public virtual ICollection<Entrant> EntrantFactAddress { get; set; }
        public virtual ICollection<Entrant> EntrantRegistrationAddress { get; set; }
    }
}
