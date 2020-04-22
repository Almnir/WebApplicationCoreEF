using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkDelete
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int ImportPackageId { get; set; }
    }
}
