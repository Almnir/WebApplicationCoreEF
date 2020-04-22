using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class DocumentCategory
    {
        public DocumentCategory()
        {
            DocumentType = new HashSet<DocumentType>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DocumentType> DocumentType { get; set; }
    }
}
