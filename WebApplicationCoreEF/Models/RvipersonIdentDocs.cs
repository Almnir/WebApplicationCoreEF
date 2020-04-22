﻿using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class RvipersonIdentDocs
    {
        public int PersonIdentDocId { get; set; }
        public int PersonId { get; set; }
        public int DocumentTypeCode { get; set; }
        public string DocumentSeries { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentOrganization { get; set; }
        public string DocumentName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual RvidocumentTypes DocumentTypeCodeNavigation { get; set; }
        public virtual Rvipersons Person { get; set; }
    }
}
