using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class EduLevels
    {
        public EduLevels()
        {
            EduLevelDocumentType = new HashSet<EduLevelDocumentType>();
        }

        public int LevelId { get; set; }
        public short AdmissionItemTypeId { get; set; }
        public string Name { get; set; }

        public virtual AdmissionItemType AdmissionItemType { get; set; }
        public virtual ICollection<EduLevelDocumentType> EduLevelDocumentType { get; set; }
    }
}
