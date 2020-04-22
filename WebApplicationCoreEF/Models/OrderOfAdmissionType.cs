using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class OrderOfAdmissionType
    {
        public int OrderTypeId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
