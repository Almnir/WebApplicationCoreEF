using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class IdentityDocumentType
    {
        public IdentityDocumentType()
        {
            TranslationRvidtIdentityDt = new HashSet<TranslationRvidtIdentityDt>();
        }

        public int IdentityDocumentTypeId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsRussianNationality { get; set; }

        public virtual ICollection<TranslationRvidtIdentityDt> TranslationRvidtIdentityDt { get; set; }
    }
}
