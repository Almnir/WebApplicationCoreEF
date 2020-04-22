using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class RegionType
    {
        public RegionType()
        {
            Address = new HashSet<Address>();
            Institution = new HashSet<Institution>();
            InstitutionHistory = new HashSet<InstitutionHistory>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string OkatoCode { get; set; }
        public DateTime? OkatoModified { get; set; }
        public int DisplayOrder { get; set; }
        public string EsrpCode { get; set; }
        public int RegionId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual CountryType Country { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Institution> Institution { get; set; }
        public virtual ICollection<InstitutionHistory> InstitutionHistory { get; set; }
    }
}
