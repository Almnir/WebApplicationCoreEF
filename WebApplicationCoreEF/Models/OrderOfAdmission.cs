using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class OrderOfAdmission
    {
        public OrderOfAdmission()
        {
            Application = new HashSet<Application>();
            OrderOfAdmissionHistory = new HashSet<OrderOfAdmissionHistory>();
        }

        public int OrderId { get; set; }
        public short OrderStatus { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateEdited { get; set; }
        public DateTime? DatePublished { get; set; }
        public int InstitutionId { get; set; }
        public string Uid { get; set; }
        public int CampaignId { get; set; }
        public int? Course { get; set; }
        public short? EducationLevelId { get; set; }
        public short? EducationFormId { get; set; }
        public short? EducationSourceId { get; set; }
        public short? Stage { get; set; }
        public bool IsForBeneficiary { get; set; }
        public bool IsForeigner { get; set; }
        public string OrderName { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual Campaign Campaign { get; set; }
        public virtual AdmissionItemType EducationForm { get; set; }
        public virtual AdmissionItemType EducationLevel { get; set; }
        public virtual AdmissionItemType EducationSource { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<OrderOfAdmissionHistory> OrderOfAdmissionHistory { get; set; }
    }
}
