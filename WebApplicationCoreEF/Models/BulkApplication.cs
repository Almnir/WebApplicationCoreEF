using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkApplication
    {
        public int ApplicationId { get; set; }
        public int? EntrantId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int InstitutionId { get; set; }
        public bool? ApproveInstitutionCount { get; set; }
        public bool? NeedHostel { get; set; }
        public bool? FirstHigherEducation { get; set; }
        public bool? ApprovePersonalData { get; set; }
        public bool? FamiliarWithLicenseAndRules { get; set; }
        public bool? FamiliarWithAdmissionType { get; set; }
        public bool? FamiliarWithOriginalDocumentDeliveryDate { get; set; }
        public int StatusId { get; set; }
        public int WizardStepId { get; set; }
        public int ViolationId { get; set; }
        public string StatusDecision { get; set; }
        public DateTime? LastCheckDate { get; set; }
        public string ViolationErrors { get; set; }
        public DateTime? PublishDate { get; set; }
        public byte SourceId { get; set; }
        public string ApplicationNumber { get; set; }
        public bool OriginalDocumentsReceived { get; set; }
        public int? OrderCompetitiveGroupId { get; set; }
        public int? OrderOfAdmissionId { get; set; }
        public int? OrderCompetitiveGroupItemId { get; set; }
        public decimal? OrderCalculatedRating { get; set; }
        public short? OrderCalculatedBenefitId { get; set; }
        public short? OrderEducationFormId { get; set; }
        public short? OrderEducationSourceId { get; set; }
        public DateTime? LastDenyDate { get; set; }
        public string Uid { get; set; }
        public bool IsRequiresBudgetO { get; set; }
        public bool IsRequiresBudgetOz { get; set; }
        public bool IsRequiresBudgetZ { get; set; }
        public bool IsRequiresPaidO { get; set; }
        public bool IsRequiresPaidOz { get; set; }
        public bool IsRequiresPaidZ { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? OriginalDocumentsReceivedDate { get; set; }
        public DateTime? LastEgeDocumentsCheckDate { get; set; }
        public int? OrderCompetitiveGroupTargetId { get; set; }
        public bool IsRequiresTargetO { get; set; }
        public bool IsRequiresTargetOz { get; set; }
        public bool IsRequiresTargetZ { get; set; }
        public Guid? ApplicationGuid { get; set; }
        public int? Priority { get; set; }
        public string EntrantUid { get; set; }
        public int ImportPackageId { get; set; }
    }
}
