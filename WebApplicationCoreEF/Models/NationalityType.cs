﻿using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class NationalityType
    {
        public int NationalityId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
