﻿using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class BulkEntrantDocument
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Uid { get; set; }
        public int ImportPackageId { get; set; }
        public int InstitutionId { get; set; }
        public string InstitutionName { get; set; }
        public bool OriginalReceived { get; set; }
        public DateTime? OriginalReceivedDate { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentOrganization { get; set; }
        public string DocumentSeries { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentSpecificData { get; set; }
        public int? IdentityDocumentTypeId { get; set; }
        public int? NationalityTypeId { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? EndYear { get; set; }
        public string BirthPlace { get; set; }
        public string SubdivisionCode { get; set; }
        public string RegistrationNumber { get; set; }
        public string QualificationName { get; set; }
        public string SpecialityName { get; set; }
        public int? SpecializationId { get; set; }
        public int? ProfessionId { get; set; }
        public string DocumentTypeNameText { get; set; }
        public string AdditionalInfo { get; set; }
        public int? DisabilityTypeId { get; set; }
        public int? DiplomaTypeId { get; set; }
        public int? OlympicId { get; set; }
        public string OlympicPlace { get; set; }
        public DateTime? OlympicDate { get; set; }
        public Guid? EntranceTestResultId { get; set; }
        public float? Gpa { get; set; }
        public int? EntrantDocumentId { get; set; }
    }
}
