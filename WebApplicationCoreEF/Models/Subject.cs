using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class Subject
    {
        public Subject()
        {
            ApplicationEntranceTestDocument = new HashSet<ApplicationEntranceTestDocument>();
            BenefitItemSubject = new HashSet<BenefitItemSubject>();
            CourseSubject = new HashSet<CourseSubject>();
            DirectionSubjectLink = new HashSet<DirectionSubjectLink>();
            DirectionSubjectLinkSubject = new HashSet<DirectionSubjectLinkSubject>();
            EntranceTestItemC = new HashSet<EntranceTestItemC>();
            EntrantDocumentMarks = new HashSet<EntrantDocumentMarks>();
            FbsToFisMap = new HashSet<FbsToFisMap>();
            OlympicTypeSubjectLink = new HashSet<OlympicTypeSubjectLink>();
        }

        public int SubjectId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsEge { get; set; }

        public virtual SubjectEgeMinValue SubjectEgeMinValue { get; set; }
        public virtual ICollection<ApplicationEntranceTestDocument> ApplicationEntranceTestDocument { get; set; }
        public virtual ICollection<BenefitItemSubject> BenefitItemSubject { get; set; }
        public virtual ICollection<CourseSubject> CourseSubject { get; set; }
        public virtual ICollection<DirectionSubjectLink> DirectionSubjectLink { get; set; }
        public virtual ICollection<DirectionSubjectLinkSubject> DirectionSubjectLinkSubject { get; set; }
        public virtual ICollection<EntranceTestItemC> EntranceTestItemC { get; set; }
        public virtual ICollection<EntrantDocumentMarks> EntrantDocumentMarks { get; set; }
        public virtual ICollection<FbsToFisMap> FbsToFisMap { get; set; }
        public virtual ICollection<OlympicTypeSubjectLink> OlympicTypeSubjectLink { get; set; }
    }
}
