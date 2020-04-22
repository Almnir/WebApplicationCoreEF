using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class TranslationRvidtIdentityDt
    {
        public int Id { get; set; }
        public int DocumentTypeCode { get; set; }
        public int IdentityDocumentTypeId { get; set; }

        public virtual RvidocumentTypes DocumentTypeCodeNavigation { get; set; }
        public virtual IdentityDocumentType IdentityDocumentType { get; set; }
    }
}
