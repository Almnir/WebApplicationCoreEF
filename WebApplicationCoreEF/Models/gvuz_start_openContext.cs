using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplicationCoreEF.Models
{
    public partial class gvuz_start_openContext : DbContext
    {
        public gvuz_start_openContext()
        {
        }

        public gvuz_start_openContext(DbContextOptions<gvuz_start_openContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AdmissionData> AdmissionData { get; set; }
        public virtual DbSet<AdmissionItemType> AdmissionItemType { get; set; }
        public virtual DbSet<AdmissionRules> AdmissionRules { get; set; }
        public virtual DbSet<AdmissionVolume> AdmissionVolume { get; set; }
        public virtual DbSet<AdmissionVolumeKcp> AdmissionVolumeKcp { get; set; }
        public virtual DbSet<AllowedDirections> AllowedDirections { get; set; }
        public virtual DbSet<AppealStatus> AppealStatus { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<ApplicationCheckStatus> ApplicationCheckStatus { get; set; }
        public virtual DbSet<ApplicationCompetitiveGroupItem> ApplicationCompetitiveGroupItem { get; set; }
        public virtual DbSet<ApplicationCompositionResults> ApplicationCompositionResults { get; set; }
        public virtual DbSet<ApplicationCompositionResultsApprob> ApplicationCompositionResultsApprob { get; set; }
        public virtual DbSet<ApplicationConsidered> ApplicationConsidered { get; set; }
        public virtual DbSet<ApplicationEntranceTestDocument> ApplicationEntranceTestDocument { get; set; }
        public virtual DbSet<ApplicationEntrantDocument> ApplicationEntrantDocument { get; set; }
        public virtual DbSet<ApplicationExportRequest> ApplicationExportRequest { get; set; }
        public virtual DbSet<ApplicationExtra> ApplicationExtra { get; set; }
        public virtual DbSet<ApplicationExtraDefinition> ApplicationExtraDefinition { get; set; }
        public virtual DbSet<ApplicationSelectedCompetitiveGroup> ApplicationSelectedCompetitiveGroup { get; set; }
        public virtual DbSet<ApplicationSelectedCompetitiveGroupItem> ApplicationSelectedCompetitiveGroupItem { get; set; }
        public virtual DbSet<ApplicationSelectedCompetitiveGroupTarget> ApplicationSelectedCompetitiveGroupTarget { get; set; }
        public virtual DbSet<ApplicationStatusType> ApplicationStatusType { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }
        public virtual DbSet<AspnetPaths> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfile { get; set; }
        public virtual DbSet<AspnetRoles> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<Benefit> Benefit { get; set; }
        public virtual DbSet<BenefitItemC> BenefitItemC { get; set; }
        public virtual DbSet<BenefitItemColympicType> BenefitItemColympicType { get; set; }
        public virtual DbSet<BenefitItemSubject> BenefitItemSubject { get; set; }
        public virtual DbSet<BlkApplication> BlkApplication { get; set; }
        public virtual DbSet<BlkApplicationCompetitiveGroupItem> BlkApplicationCompetitiveGroupItem { get; set; }
        public virtual DbSet<BlkApplicationEntranceTestDocument> BlkApplicationEntranceTestDocument { get; set; }
        public virtual DbSet<BlkApplicationIndividualAchievements> BlkApplicationIndividualAchievements { get; set; }
        public virtual DbSet<BlkApplicationSelectedCompetitiveGroup> BlkApplicationSelectedCompetitiveGroup { get; set; }
        public virtual DbSet<BlkApplicationSelectedCompetitiveGroupItem> BlkApplicationSelectedCompetitiveGroupItem { get; set; }
        public virtual DbSet<BlkApplicationSelectedCompetitiveGroupTarget> BlkApplicationSelectedCompetitiveGroupTarget { get; set; }
        public virtual DbSet<BlkConsideredApplication> BlkConsideredApplication { get; set; }
        public virtual DbSet<BlkEntrant> BlkEntrant { get; set; }
        public virtual DbSet<BlkEntrantDocument> BlkEntrantDocument { get; set; }
        public virtual DbSet<BlkEntrantDocumentEgeAndOlympicSubject> BlkEntrantDocumentEgeAndOlympicSubject { get; set; }
        public virtual DbSet<BlkRecommendedApplication> BlkRecommendedApplication { get; set; }
        public virtual DbSet<BlkRecommendedList> BlkRecommendedList { get; set; }
        public virtual DbSet<BulkAdmissionVolume> BulkAdmissionVolume { get; set; }
        public virtual DbSet<BulkApplication> BulkApplication { get; set; }
        public virtual DbSet<BulkApplicationCompetitiveGroupItem> BulkApplicationCompetitiveGroupItem { get; set; }
        public virtual DbSet<BulkApplicationEntranceTestDocument> BulkApplicationEntranceTestDocument { get; set; }
        public virtual DbSet<BulkApplicationIndividualAchievements> BulkApplicationIndividualAchievements { get; set; }
        public virtual DbSet<BulkApplicationSelectedCompetitiveGroup> BulkApplicationSelectedCompetitiveGroup { get; set; }
        public virtual DbSet<BulkApplicationSelectedCompetitiveGroupItem> BulkApplicationSelectedCompetitiveGroupItem { get; set; }
        public virtual DbSet<BulkApplicationSelectedCompetitiveGroupTarget> BulkApplicationSelectedCompetitiveGroupTarget { get; set; }
        public virtual DbSet<BulkBenefitItemC> BulkBenefitItemC { get; set; }
        public virtual DbSet<BulkBenefitItemData> BulkBenefitItemData { get; set; }
        public virtual DbSet<BulkCampaign> BulkCampaign { get; set; }
        public virtual DbSet<BulkCampaignDate> BulkCampaignDate { get; set; }
        public virtual DbSet<BulkCompetitiveGroup> BulkCompetitiveGroup { get; set; }
        public virtual DbSet<BulkCompetitiveGroupItem> BulkCompetitiveGroupItem { get; set; }
        public virtual DbSet<BulkCompetitiveGroupTarget> BulkCompetitiveGroupTarget { get; set; }
        public virtual DbSet<BulkCompetitiveGroupTargetItem> BulkCompetitiveGroupTargetItem { get; set; }
        public virtual DbSet<BulkDelete> BulkDelete { get; set; }
        public virtual DbSet<BulkDistributedAdmissionVolume> BulkDistributedAdmissionVolume { get; set; }
        public virtual DbSet<BulkEntranceTestItemC> BulkEntranceTestItemC { get; set; }
        public virtual DbSet<BulkEntrant> BulkEntrant { get; set; }
        public virtual DbSet<BulkEntrantDocument> BulkEntrantDocument { get; set; }
        public virtual DbSet<BulkEntrantDocumentSubject> BulkEntrantDocumentSubject { get; set; }
        public virtual DbSet<BulkInstitutionAchievements> BulkInstitutionAchievements { get; set; }
        public virtual DbSet<BulkOrderOfAdmission> BulkOrderOfAdmission { get; set; }
        public virtual DbSet<Campaign> Campaign { get; set; }
        public virtual DbSet<CampaignDate> CampaignDate { get; set; }
        public virtual DbSet<CampaignEducationLevel> CampaignEducationLevel { get; set; }
        public virtual DbSet<CampaignOrderDateCatalog> CampaignOrderDateCatalog { get; set; }
        public virtual DbSet<CampaignStatus> CampaignStatus { get; set; }
        public virtual DbSet<CityType> CityType { get; set; }
        public virtual DbSet<CompetitiveGroup> CompetitiveGroup { get; set; }
        public virtual DbSet<CompetitiveGroupItem> CompetitiveGroupItem { get; set; }
        public virtual DbSet<CompetitiveGroupTarget> CompetitiveGroupTarget { get; set; }
        public virtual DbSet<CompetitiveGroupTargetItem> CompetitiveGroupTargetItem { get; set; }
        public virtual DbSet<CompositionThemes> CompositionThemes { get; set; }
        public virtual DbSet<CompositionThemesApprob> CompositionThemesApprob { get; set; }
        public virtual DbSet<CountryType> CountryType { get; set; }
        public virtual DbSet<CourseSubject> CourseSubject { get; set; }
        public virtual DbSet<CourseType> CourseType { get; set; }
        public virtual DbSet<Direction> Direction { get; set; }
        public virtual DbSet<DirectionSubjectLink> DirectionSubjectLink { get; set; }
        public virtual DbSet<DirectionSubjectLinkDirection> DirectionSubjectLinkDirection { get; set; }
        public virtual DbSet<DirectionSubjectLinkSubject> DirectionSubjectLinkSubject { get; set; }
        public virtual DbSet<DirectionTmp> DirectionTmp { get; set; }
        public virtual DbSet<DisabilityType> DisabilityType { get; set; }
        public virtual DbSet<DistributedAdmissionVolume> DistributedAdmissionVolume { get; set; }
        public virtual DbSet<DocumentCategory> DocumentCategory { get; set; }
        public virtual DbSet<DocumentCheckStatus> DocumentCheckStatus { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<EduLevelDocumentType> EduLevelDocumentType { get; set; }
        public virtual DbSet<EduLevels> EduLevels { get; set; }
        public virtual DbSet<EntranceTestCreativeDirection> EntranceTestCreativeDirection { get; set; }
        public virtual DbSet<EntranceTestItemC> EntranceTestItemC { get; set; }
        public virtual DbSet<EntranceTestProfileDirection> EntranceTestProfileDirection { get; set; }
        public virtual DbSet<EntranceTestResultSource> EntranceTestResultSource { get; set; }
        public virtual DbSet<EntranceTestType> EntranceTestType { get; set; }
        public virtual DbSet<Entrant> Entrant { get; set; }
        public virtual DbSet<EntrantDocument> EntrantDocument { get; set; }
        public virtual DbSet<EntrantDocumentCustom> EntrantDocumentCustom { get; set; }
        public virtual DbSet<EntrantDocumentDisability> EntrantDocumentDisability { get; set; }
        public virtual DbSet<EntrantDocumentEdu> EntrantDocumentEdu { get; set; }
        public virtual DbSet<EntrantDocumentEge> EntrantDocumentEge { get; set; }
        public virtual DbSet<EntrantDocumentEgeAndOlympicSubject> EntrantDocumentEgeAndOlympicSubject { get; set; }
        public virtual DbSet<EntrantDocumentIdentity> EntrantDocumentIdentity { get; set; }
        public virtual DbSet<EntrantDocumentIdentityTmp> EntrantDocumentIdentityTmp { get; set; }
        public virtual DbSet<EntrantDocumentMarks> EntrantDocumentMarks { get; set; }
        public virtual DbSet<EntrantDocumentOlympic> EntrantDocumentOlympic { get; set; }
        public virtual DbSet<EntrantDocumentOlympicTotal> EntrantDocumentOlympicTotal { get; set; }
        public virtual DbSet<EntrantLanguage> EntrantLanguage { get; set; }
        public virtual DbSet<FbsToFisMap> FbsToFisMap { get; set; }
        public virtual DbSet<ForeignLanguageType> ForeignLanguageType { get; set; }
        public virtual DbSet<FormOfLaw> FormOfLaw { get; set; }
        public virtual DbSet<FtcRandDouble> FtcRandDouble { get; set; }
        public virtual DbSet<GenderType> GenderType { get; set; }
        public virtual DbSet<GlobalMinEge> GlobalMinEge { get; set; }
        public virtual DbSet<IdentityDocumentType> IdentityDocumentType { get; set; }
        public virtual DbSet<ImportPackage> ImportPackage { get; set; }
        public virtual DbSet<ImportPackageStatus> ImportPackageStatus { get; set; }
        public virtual DbSet<ImportPackageType> ImportPackageType { get; set; }
        public virtual DbSet<IndividualAchievementsCategory> IndividualAchievementsCategory { get; set; }
        public virtual DbSet<IndividualAchivement> IndividualAchivement { get; set; }
        public virtual DbSet<Institution> Institution { get; set; }
        public virtual DbSet<InstitutionAccreditation> InstitutionAccreditation { get; set; }
        public virtual DbSet<InstitutionAchievements> InstitutionAchievements { get; set; }
        public virtual DbSet<InstitutionDocumentType> InstitutionDocumentType { get; set; }
        public virtual DbSet<InstitutionHistory> InstitutionHistory { get; set; }
        public virtual DbSet<InstitutionItem> InstitutionItem { get; set; }
        public virtual DbSet<InstitutionItemType> InstitutionItemType { get; set; }
        public virtual DbSet<InstitutionLicense> InstitutionLicense { get; set; }
        public virtual DbSet<InstitutionStructure> InstitutionStructure { get; set; }
        public virtual DbSet<InstitutionType> InstitutionType { get; set; }
        public virtual DbSet<LevelBudget> LevelBudget { get; set; }
        public virtual DbSet<MapAdmissionData> MapAdmissionData { get; set; }
        public virtual DbSet<MapAdmissionVolume> MapAdmissionVolume { get; set; }
        public virtual DbSet<MapApplication> MapApplication { get; set; }
        public virtual DbSet<MapApplicationSelectedCompetitiveGroupItem> MapApplicationSelectedCompetitiveGroupItem { get; set; }
        public virtual DbSet<MapCompetitiveGroupItem> MapCompetitiveGroupItem { get; set; }
        public virtual DbSet<MapCompetitiveGroupTargetItem> MapCompetitiveGroupTargetItem { get; set; }
        public virtual DbSet<MapDirections> MapDirections { get; set; }
        public virtual DbSet<MapEntranceTestProfileDirection> MapEntranceTestProfileDirection { get; set; }
        public virtual DbSet<MapInstitutionItem> MapInstitutionItem { get; set; }
        public virtual DbSet<MapInstitutionStructure> MapInstitutionStructure { get; set; }
        public virtual DbSet<Migrations> Migrations { get; set; }
        public virtual DbSet<NationalityType> NationalityType { get; set; }
        public virtual DbSet<NormativeDictionary> NormativeDictionary { get; set; }
        public virtual DbSet<NormativeVersionState> NormativeVersionState { get; set; }
        public virtual DbSet<OlympicDiplomType> OlympicDiplomType { get; set; }
        public virtual DbSet<OlympicLevel> OlympicLevel { get; set; }
        public virtual DbSet<OlympicType> OlympicType { get; set; }
        public virtual DbSet<OlympicTypeSubjectLink> OlympicTypeSubjectLink { get; set; }
        public virtual DbSet<OrderOfAdmission> OrderOfAdmission { get; set; }
        public virtual DbSet<OrderOfAdmissionHistory> OrderOfAdmissionHistory { get; set; }
        public virtual DbSet<OrderOfAdmissionType> OrderOfAdmissionType { get; set; }
        public virtual DbSet<ParentDirection> ParentDirection { get; set; }
        public virtual DbSet<ParentDirectionOld> ParentDirectionOld { get; set; }
        public virtual DbSet<PersonalDataAccessLog> PersonalDataAccessLog { get; set; }
        public virtual DbSet<PreparatoryCourse> PreparatoryCourse { get; set; }
        public virtual DbSet<RecomendedLists> RecomendedLists { get; set; }
        public virtual DbSet<RecomendedListsHistory> RecomendedListsHistory { get; set; }
        public virtual DbSet<RegionType> RegionType { get; set; }
        public virtual DbSet<RequestComments> RequestComments { get; set; }
        public virtual DbSet<RequestDirection> RequestDirection { get; set; }
        public virtual DbSet<RvidocumentTypes> RvidocumentTypes { get; set; }
        public virtual DbSet<RvipersonIdentDocs> RvipersonIdentDocs { get; set; }
        public virtual DbSet<Rvipersons> Rvipersons { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<SubjectEgeMinValue> SubjectEgeMinValue { get; set; }
        public virtual DbSet<SubjectEgeMinValueCopy> SubjectEgeMinValueCopy { get; set; }
        public virtual DbSet<TmpEgeMarksStat> TmpEgeMarksStat { get; set; }
        public virtual DbSet<TranslationRvidtIdentityDt> TranslationRvidtIdentityDt { get; set; }
        public virtual DbSet<UserPolicy> UserPolicy { get; set; }
        public virtual DbSet<VCompetitiveGroup> VCompetitiveGroup { get; set; }
        public virtual DbSet<VEntrantDocuments> VEntrantDocuments { get; set; }
        public virtual DbSet<ViolationType> ViolationType { get; set; }
        public virtual DbSet<VwAspnetApplications> VwAspnetApplications { get; set; }
        public virtual DbSet<VwAspnetMembershipUsers> VwAspnetMembershipUsers { get; set; }
        public virtual DbSet<VwAspnetProfiles> VwAspnetProfiles { get; set; }
        public virtual DbSet<VwAspnetRoles> VwAspnetRoles { get; set; }
        public virtual DbSet<VwAspnetUsers> VwAspnetUsers { get; set; }
        public virtual DbSet<VwAspnetUsersInRoles> VwAspnetUsersInRoles { get; set; }
        public virtual DbSet<VwAspnetWebPartStatePaths> VwAspnetWebPartStatePaths { get; set; }
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShared { get; set; }
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=10.0.18.3;Initial Catalog=gvuz_start_open;Persist Security Info=True;User ID=ra;Password=Njkmrjcdjb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.Building)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingPart)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Room)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Address_CountryType");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Address_RegionType");
            });

            modelBuilder.Entity<AdmissionData>(entity =>
            {
                entity.HasKey(e => e.AdmissionStructureId)
                    .IsClustered(false);

                entity.HasIndex(e => e.AdmissionItemId)
                    .HasName("UK_AdmissionData_Item")
                    .IsUnique();

                entity.HasIndex(e => e.Depth);

                entity.HasIndex(e => e.Lineage)
                    .HasName("UK_AdmissionData_Lineage")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_AdmissionData_Parent");

                entity.HasIndex(e => new { e.HasMilitaryDepartment, e.HasPreparatoryCourses, e.HasOlympics, e.EducationLevelId, e.DirectionId, e.StudyId, e.AdmissionTypeId, e.InstitutionId, e.ItemLevel, e.Depth })
                    .HasName("IX_AdmissionData_InstitutionID");

                entity.Property(e => e.AdmissionStructureId)
                    .HasColumnName("AdmissionStructureID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdmissionItemId).HasColumnName("AdmissionItemID");

                entity.Property(e => e.AdmissionTypeId).HasColumnName("AdmissionTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.Lineage)
                    .IsRequired()
                    .HasMaxLength(146)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.StudyId).HasColumnName("StudyID");
            });

            modelBuilder.Entity<AdmissionItemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.HasIndex(e => e.Name)
                    .HasName("UK_AdmissionItemType_Name")
                    .IsUnique();

                entity.Property(e => e.ItemTypeId)
                    .HasColumnName("ItemTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdmissionRules>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK_AdmissionRules_1");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.File).IsRequired();

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdmissionVolume>(entity =>
            {
                entity.HasIndex(e => new { e.AdmissionVolumeId, e.CampaignId })
                    .HasName("_dta_index_AdmissionVolume_12_1472724299__K16_1");

                entity.Property(e => e.AdmissionVolumeId).HasColumnName("AdmissionVolumeID");

                entity.Property(e => e.AdmissionItemTypeId).HasColumnName("AdmissionItemTypeID");

                entity.Property(e => e.AdmissionVolumeGuid).HasColumnName("AdmissionVolumeGUID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NumberBudgetOz).HasColumnName("NumberBudgetOZ");

                entity.Property(e => e.NumberPaidOz).HasColumnName("NumberPaidOZ");

                entity.Property(e => e.NumberQuotaOz).HasColumnName("NumberQuotaOZ");

                entity.Property(e => e.NumberTargetOz).HasColumnName("NumberTargetOZ");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.AdmissionItemType)
                    .WithMany(p => p.AdmissionVolume)
                    .HasForeignKey(d => d.AdmissionItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmissionVolume_AdmissionItemType");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.AdmissionVolume)
                    .HasForeignKey(d => d.CampaignId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AdmissionVolume_Campaign");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.AdmissionVolume)
                    .HasForeignKey(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmissionVolume_Direction");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.AdmissionVolume)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmissionVolume_Institution");
            });

            modelBuilder.Entity<AdmissionVolumeKcp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AdmissionVolumeKCP");

                entity.Property(e => e.AdmissionItemTypeId).HasColumnName("AdmissionItemTypeID");

                entity.Property(e => e.AdmissionVolumeId).HasColumnName("AdmissionVolumeID");

                entity.Property(e => e.DirectionId)
                    .HasColumnName("DirectionID")
                    .HasMaxLength(255);

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.NumberBudgetOz).HasColumnName("NumberBudgetOZ");
            });

            modelBuilder.Entity<AllowedDirections>(entity =>
            {
                entity.HasKey(e => new { e.InstitutionId, e.DirectionId, e.AdmissionItemTypeId });

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.AdmissionItemTypeId).HasColumnName("AdmissionItemTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.AdmissionItemType)
                    .WithMany(p => p.AllowedDirections)
                    .HasForeignKey(d => d.AdmissionItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AllowedDirections_AdmissionItemType");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.AllowedDirections)
                    .HasForeignKey(d => d.DirectionId)
                    .HasConstraintName("FK_AllowedDirections_Direction");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.AllowedDirections)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_AllowedDirections_Institution");
            });

            modelBuilder.Entity<AppealStatus>(entity =>
            {
                entity.Property(e => e.AppealStatusId)
                    .HasColumnName("AppealStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.HasIndex(e => e.EntrantId)
                    .HasName("idx_EntrantID");

                entity.HasIndex(e => e.OrderCompetitiveGroupId)
                    .HasName("idx_OrderCompetitiveGroup");

                entity.HasIndex(e => e.OrderCompetitiveGroupItemId)
                    .HasName("idx_OrderCompetitiveGroupItem");

                entity.HasIndex(e => e.OrderOfAdmissionId)
                    .HasName("_dta_index_Application_12_1108198998__K24");

                entity.HasIndex(e => new { e.ApplicationGuid, e.EntrantId })
                    .HasName("_dta_index_Application_10_1108198998__K48_K2");

                entity.HasIndex(e => new { e.InstitutionId, e.ApplicationId })
                    .HasName("_dta_index_Application_12_1108198998__K4_K1");

                entity.HasIndex(e => new { e.StatusId, e.RegistrationDate, e.ApplicationId })
                    .HasName("_dta_index_Application_12_1108198998__K12_K3_K1");

                entity.HasIndex(e => new { e.Uid, e.ApplicationId, e.InstitutionId })
                    .HasName("_dta_index_Application_12_1108198998__K1_K4_31");

                entity.HasIndex(e => new { e.Uid, e.InstitutionId, e.ApplicationId })
                    .HasName("_dta_index_Application_12_1108198998__K4_K1_31");

                entity.HasIndex(e => new { e.ApplicationId, e.RegistrationDate, e.Uid, e.StatusId, e.ApplicationNumber, e.OrderCompetitiveGroupId })
                    .HasName("idx_CGDependencyChecker");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ApplicationGuid).HasColumnName("ApplicationGUID");

                entity.Property(e => e.ApplicationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntrantId).HasColumnName("EntrantID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.IsRequiresBudgetOz).HasColumnName("IsRequiresBudgetOZ");

                entity.Property(e => e.IsRequiresPaidOz).HasColumnName("IsRequiresPaidOZ");

                entity.Property(e => e.IsRequiresTargetOz).HasColumnName("IsRequiresTargetOZ");

                entity.Property(e => e.LastCheckDate).HasColumnType("datetime");

                entity.Property(e => e.LastDenyDate).HasColumnType("datetime");

                entity.Property(e => e.LastEgeDocumentsCheckDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderCalculatedBenefitId).HasColumnName("OrderCalculatedBenefitID");

                entity.Property(e => e.OrderCalculatedRating)
                    .HasColumnType("decimal(10, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderCompetitiveGroupId).HasColumnName("OrderCompetitiveGroupID");

                entity.Property(e => e.OrderCompetitiveGroupItemId).HasColumnName("OrderCompetitiveGroupItemID");

                entity.Property(e => e.OrderCompetitiveGroupTargetId).HasColumnName("OrderCompetitiveGroupTargetID");

                entity.Property(e => e.OrderEducationFormId).HasColumnName("OrderEducationFormID");

                entity.Property(e => e.OrderEducationSourceId).HasColumnName("OrderEducationSourceID");

                entity.Property(e => e.OrderOfAdmissionId).HasColumnName("OrderOfAdmissionID");

                entity.Property(e => e.OriginalDocumentsReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SourceId)
                    .HasColumnName("SourceID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusDecision).IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ViolationErrors).IsUnicode(false);

                entity.Property(e => e.ViolationId).HasColumnName("ViolationID");

                entity.Property(e => e.WizardStepId).HasColumnName("WizardStepID");

                entity.HasOne(d => d.Entrant)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.EntrantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Application_Entrant");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Application_Institution");

                entity.HasOne(d => d.OrderCalculatedBenefit)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.OrderCalculatedBenefitId)
                    .HasConstraintName("FK_Application_Benefit");

                entity.HasOne(d => d.OrderCompetitiveGroup)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.OrderCompetitiveGroupId)
                    .HasConstraintName("FK_Application_CompetitiveGroup");

                entity.HasOne(d => d.OrderCompetitiveGroupItem)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.OrderCompetitiveGroupItemId)
                    .HasConstraintName("FK_Application_CompetitiveGroupItem");

                entity.HasOne(d => d.OrderCompetitiveGroupTarget)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.OrderCompetitiveGroupTargetId)
                    .HasConstraintName("FK_Application_CompetitiveGroupTarget");

                entity.HasOne(d => d.OrderEducationForm)
                    .WithMany(p => p.ApplicationOrderEducationForm)
                    .HasForeignKey(d => d.OrderEducationFormId)
                    .HasConstraintName("FK_Application_AdmissionItemTypeForm");

                entity.HasOne(d => d.OrderEducationSource)
                    .WithMany(p => p.ApplicationOrderEducationSource)
                    .HasForeignKey(d => d.OrderEducationSourceId)
                    .HasConstraintName("FK_Application_AdmissionItemTypeSource");

                entity.HasOne(d => d.OrderOfAdmission)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.OrderOfAdmissionId)
                    .HasConstraintName("FK_Application_OrderOfAdmission");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Application_ApplicationStatusType");

                entity.HasOne(d => d.Violation)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.ViolationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Application_ViolationType");
            });

            modelBuilder.Entity<ApplicationCheckStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__Applicat__C8EE204374F938D6");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationCompetitiveGroupItem>(entity =>
            {
                entity.HasIndex(e => new { e.EducationFormId, e.EducationSourceId })
                    .HasName("IX_ApplicationCompetitiveGroupItem_FormSource");

                entity.HasIndex(e => new { e.EducationSourceId, e.EducationFormId })
                    .HasName("IX_ApplicationCompetitiveGroupItem_SourceForm");

                entity.HasIndex(e => new { e.ApplicationId, e.CompetitiveGroupTargetId, e.Priority })
                    .HasName("idx_CGTDependencyChecker2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationCompetitiveGroupItem)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationCompetitiveGroupItem_Application");

                entity.HasOne(d => d.CompetitiveGroup)
                    .WithMany(p => p.ApplicationCompetitiveGroupItem)
                    .HasForeignKey(d => d.CompetitiveGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationCompetitiveGroupItem_CompetitiveGroup");

                entity.HasOne(d => d.CompetitiveGroupItem)
                    .WithMany(p => p.ApplicationCompetitiveGroupItem)
                    .HasForeignKey(d => d.CompetitiveGroupItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationCompetitiveGroupItem_CompetitiveGroupItem");
            });

            modelBuilder.Entity<ApplicationCompositionResults>(entity =>
            {
                entity.HasKey(e => e.CompositionId)
                    .HasName("PK__Applicat__B8E2333F2A962F78");

                entity.Property(e => e.CompositionId)
                    .HasColumnName("CompositionID")
                    .HasComment("ИД записи");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .HasComment("ИД заявления FK (Application - Application-ID)");

                entity.Property(e => e.SourceId)
                    .IsRequired()
                    .HasColumnName("SourceID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Ссылка на запись в Системе- источнике результатов сочинений");

                entity.Property(e => e.ThemeId)
                    .HasColumnName("ThemeID")
                    .HasComment("Тема сочинения.  FK (CompositionThemes – ThemeID)");

                entity.Property(e => e.Year)
                    .HasColumnType("datetime")
                    .HasComment("Год результата сочинения");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationCompositionResults)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationCompositionResults_Application");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.ApplicationCompositionResults)
                    .HasForeignKey(d => d.ThemeId)
                    .HasConstraintName("FK_ApplicationCompositionResults_ThemeID");
            });

            modelBuilder.Entity<ApplicationCompositionResultsApprob>(entity =>
            {
                entity.HasKey(e => e.CompositionId);

                entity.ToTable("ApplicationCompositionResults_Approb");

                entity.Property(e => e.CompositionId).HasColumnName("CompositionID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ThemeId).HasColumnName("ThemeID");

                entity.Property(e => e.Year).HasColumnType("datetime");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationCompositionResultsApprob)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_ApplicationCompositionResults_Approb_Application");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.ApplicationCompositionResultsApprob)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationCompositionResults_Approb_CompositionThemes_Approb");
            });

            modelBuilder.Entity<ApplicationConsidered>(entity =>
            {
                entity.HasIndex(e => e.ApplicationId)
                    .HasName("idx_ApplicationID");

                entity.Property(e => e.ApplicationConsideredId).HasColumnName("ApplicationConsideredID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.EducationFormId).HasColumnName("EducationFormID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.FinanceSourceId).HasColumnName("FinanceSourceID");

                entity.Property(e => e.IsRequiresBudgetOz).HasColumnName("IsRequiresBudgetOZ");

                entity.Property(e => e.IsRequiresPaidOz).HasColumnName("IsRequiresPaidOZ");

                entity.Property(e => e.IsRequiresTargetOz).HasColumnName("IsRequiresTargetOZ");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationConsidered)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationConsidered_Application");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.ApplicationConsidered)
                    .HasForeignKey(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationConsidered_Direction");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.ApplicationConsidered)
                    .HasForeignKey(d => d.EducationLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationConsidered_AdmissionItemType");
            });

            modelBuilder.Entity<ApplicationEntranceTestDocument>(entity =>
            {
                entity.HasIndex(e => e.EntranceTestItemId)
                    .HasName("_dta_index_ApplicationEntranceTestDocument_12_448720651__K9");

                entity.HasIndex(e => e.EntrantDocumentId)
                    .HasName("idx_EntrantDocument");

                entity.HasIndex(e => new { e.ApplicationId, e.EntrantDocumentId })
                    .HasName("idx_ApplicationDocument");

                entity.HasIndex(e => new { e.Id, e.ApplicationId })
                    .HasName("idx_ApplicationID");

                entity.HasIndex(e => new { e.ApplicationId, e.BenefitId, e.EntranceTestItemId })
                    .HasName("dlidx_1");

                entity.HasIndex(e => new { e.BenefitId, e.EntranceTestItemId, e.ApplicationId })
                    .HasName("_dta_index_ApplicationEntranceTestDocument_12_448720651__K8_K9_K2");

                entity.HasIndex(e => new { e.EntranceTestTypeId, e.SourceId, e.ResultValue, e.BenefitId, e.EntranceTestItemId, e.Uid, e.CreatedDate, e.ModifiedDate, e.InstitutionDocumentNumber, e.InstitutionDocumentDate, e.InstitutionDocumentTypeId, e.SubjectId, e.EntrantDocumentId, e.HasEge, e.ApplicationId, e.Id, e.CompetitiveGroupId })
                    .HasName("_dta_index_ApplicationEntranceTestDocument_12_448720651__K2_K1_K16_3_4_5_6_7_8_9_10_11_12_13_14_15_17");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppealStatusId).HasColumnName("AppealStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BenefitId).HasColumnName("BenefitID");

                entity.Property(e => e.CompetitiveGroupId).HasColumnName("CompetitiveGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EgeResultValue).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.EntranceTestItemId).HasColumnName("EntranceTestItemID");

                entity.Property(e => e.EntranceTestTypeId).HasColumnName("EntranceTestTypeID");

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.InstitutionDocumentDate).HasColumnType("datetime");

                entity.Property(e => e.InstitutionDocumentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionDocumentTypeId).HasColumnName("InstitutionDocumentTypeID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ResultValue).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.AppealStatus)
                    .WithMany(p => p.ApplicationEntranceTestDocument)
                    .HasForeignKey(d => d.AppealStatusId)
                    .HasConstraintName("FK_ApplicationEntranceTestDocument_AppealStatus");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationEntranceTestDocument)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationEntranceTestDocument_Application");

                entity.HasOne(d => d.Benefit)
                    .WithMany(p => p.ApplicationEntranceTestDocument)
                    .HasForeignKey(d => d.BenefitId)
                    .HasConstraintName("FK_ApplicationEntranceTestDocument_Benefit");

                entity.HasOne(d => d.CompetitiveGroup)
                    .WithMany(p => p.ApplicationEntranceTestDocument)
                    .HasForeignKey(d => d.CompetitiveGroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ApplicationEntranceTestDocument_CompetitiveGroup");

                entity.HasOne(d => d.EntranceTestItem)
                    .WithMany(p => p.ApplicationEntranceTestDocument)
                    .HasForeignKey(d => d.EntranceTestItemId)
                    .HasConstraintName("FK_ApplicationEntranceTestDocument_EntranceTestItemC");

                entity.HasOne(d => d.EntranceTestType)
                    .WithMany(p => p.ApplicationEntranceTestDocument)
                    .HasForeignKey(d => d.EntranceTestTypeId)
                    .HasConstraintName("FK_ApplicationEntranceTestDocument_EntranceTestType");

                entity.HasOne(d => d.EntrantDocument)
                    .WithMany(p => p.ApplicationEntranceTestDocument)
                    .HasForeignKey(d => d.EntrantDocumentId)
                    .HasConstraintName("FK_ApplicationEntranceTestDocument_EntrantDocument");

                entity.HasOne(d => d.InstitutionDocumentType)
                    .WithMany(p => p.ApplicationEntranceTestDocument)
                    .HasForeignKey(d => d.InstitutionDocumentTypeId)
                    .HasConstraintName("FK_ApplicationEntranceTestDocument_InstitutionDocumentType");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.ApplicationEntranceTestDocument)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_ApplicationEntranceTestDocument_EntranceTestResultSource");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.ApplicationEntranceTestDocument)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_ApplicationEntranceTestDocument_Subject");
            });

            modelBuilder.Entity<ApplicationEntrantDocument>(entity =>
            {
                entity.HasIndex(e => e.EntrantDocumentId)
                    .HasName("idx_EntrantDocument");

                entity.HasIndex(e => new { e.ApplicationId, e.EntrantDocumentId })
                    .HasName("idx_ApplicationDocument");

                entity.HasIndex(e => new { e.EntrantDocumentId, e.ApplicationId })
                    .HasName("_dta_index_ApplicationEntrantDocument_12_272720024__K3_K2");

                entity.HasIndex(e => new { e.Id, e.ApplicationId })
                    .HasName("idx_ApplicationID");

                entity.HasIndex(e => new { e.AttachedDocumentType, e.Uid, e.CreatedDate, e.ModifiedDate, e.OriginalReceivedDate, e.EntrantDocumentId, e.Id, e.ApplicationId })
                    .HasName("_dta_index_ApplicationEntrantDocument_12_272720024__K3_K1_K2_4_5_6_7_8");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationEntrantDocument)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationEntrantDocument_Application");

                entity.HasOne(d => d.EntrantDocument)
                    .WithMany(p => p.ApplicationEntrantDocument)
                    .HasForeignKey(d => d.EntrantDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationEntrantDocument_EntrantDocument");
            });

            modelBuilder.Entity<ApplicationExportRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.Property(e => e.RequestId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RequestDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ApplicationExtra>(entity =>
            {
                entity.HasIndex(e => e.ApplicationId)
                    .HasName("idx_ApplicationID");

                entity.Property(e => e.ApplicationExtraId)
                    .HasColumnName("ApplicationExtraID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationExtraDefinitionId).HasColumnName("ApplicationExtraDefinitionID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.ApplicationExtraDefinition)
                    .WithMany(p => p.ApplicationExtra)
                    .HasForeignKey(d => d.ApplicationExtraDefinitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationExtra_ApplicationExtraDefinition");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationExtra)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationExtra_Application");
            });

            modelBuilder.Entity<ApplicationExtraDefinition>(entity =>
            {
                entity.Property(e => e.ApplicationExtraDefinitionId).HasColumnName("ApplicationExtraDefinitionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationSelectedCompetitiveGroup>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.HasIndex(e => e.CompetitiveGroupId)
                    .HasName("idx_CompetitiveGroup");

                entity.HasIndex(e => new { e.ApplicationId, e.CompetitiveGroupId })
                    .HasName("_dta_index_ApplicationSelectedCompetitiveGr_12_2111346586__K2_K3");

                entity.HasIndex(e => new { e.ItemId, e.ApplicationId })
                    .HasName("idx_ApplicationID");

                entity.HasIndex(e => new { e.CalculatedRating, e.ApplicationId, e.CompetitiveGroupId, e.CalculatedBenefitId, e.ItemId })
                    .HasName("_dta_index_ApplicationSelectedCompetitiveGr_12_2111346586__K2_K3_K4_K1_5");

                entity.HasIndex(e => new { e.CalculatedRating, e.CompetitiveGroupId, e.ApplicationId, e.CalculatedBenefitId, e.ItemId })
                    .HasName("_dta_index_ApplicationSelectedCompetitiveGr_12_2111346586__K3_K2_K4_K1_5");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CalculatedBenefitId).HasColumnName("CalculatedBenefitID");

                entity.Property(e => e.CalculatedRating).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.CompetitiveGroupId).HasColumnName("CompetitiveGroupID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationSelectedCompetitiveGroup)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_ApplicationSelectedCompetitiveGroup_Application");

                entity.HasOne(d => d.CalculatedBenefit)
                    .WithMany(p => p.ApplicationSelectedCompetitiveGroup)
                    .HasForeignKey(d => d.CalculatedBenefitId)
                    .HasConstraintName("FK_ApplicationSelectedCompetitiveGroup_Benefit");

                entity.HasOne(d => d.CompetitiveGroup)
                    .WithMany(p => p.ApplicationSelectedCompetitiveGroup)
                    .HasForeignKey(d => d.CompetitiveGroupId)
                    .HasConstraintName("FK_ApplicationSelectedCompetitiveGroup_CompetitiveGroup");
            });

            modelBuilder.Entity<ApplicationSelectedCompetitiveGroupItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.HasIndex(e => e.CompetitiveGroupItemId)
                    .HasName("idx_CompetitiveGroupItem");

                entity.HasIndex(e => new { e.CompetitiveGroupItemId, e.ApplicationId })
                    .HasName("_dta_index_ApplicationSelectedCompetitiveGr_12_43863223__K3_K2");

                entity.HasIndex(e => new { e.ItemId, e.ApplicationId })
                    .HasName("idx_ApplicationID");

                entity.HasIndex(e => new { e.ItemId, e.CompetitiveGroupItemId, e.ApplicationId })
                    .HasName("_dta_index_ApplicationSelectedCompetitiveGr_12_43863223__K2_1_3");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CompetitiveGroupItemId).HasColumnName("CompetitiveGroupItemID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationSelectedCompetitiveGroupItem)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_ApplicationSelectedCompetitiveGroupItem_Application");

                entity.HasOne(d => d.CompetitiveGroupItem)
                    .WithMany(p => p.ApplicationSelectedCompetitiveGroupItem)
                    .HasForeignKey(d => d.CompetitiveGroupItemId)
                    .HasConstraintName("FK_ApplicationSelectedCompetitiveGroupItem_CompetitiveGroupItem");
            });

            modelBuilder.Entity<ApplicationSelectedCompetitiveGroupTarget>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.ApplicationId })
                    .HasName("idx_ApplicationID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CompetitiveGroupTargetId).HasColumnName("CompetitiveGroupTargetID");

                entity.Property(e => e.IsForOz).HasColumnName("IsForOZ");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationSelectedCompetitiveGroupTarget)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_ApplicationSelectedCompetitiveGroupTarget_Application");

                entity.HasOne(d => d.CompetitiveGroupTarget)
                    .WithMany(p => p.ApplicationSelectedCompetitiveGroupTarget)
                    .HasForeignKey(d => d.CompetitiveGroupTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationSelectedCompetitiveGroupTarget_CompetitiveGroupTarget");
            });

            modelBuilder.Entity<ApplicationStatusType>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_Applicati__6477ECF3")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_Applicati__66603565")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_Membershi__797309D9")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail })
                    .HasName("aspnet_Membership_index")
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMembership)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__7A672E12");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__7B5B524B");
            });

            modelBuilder.Entity<AspnetPaths>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_Paths__2B0A656D")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath })
                    .HasName("aspnet_Paths_index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__2BFE89A6");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUsers>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_Personali__30C33EC3");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUsers)
                    .HasForeignKey<AspnetPersonalizationAllUsers>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__31B762FC");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_Personali__339FAB6E")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.HasIndex(e => new { e.PathId, e.UserId })
                    .HasName("aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId })
                    .HasName("aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__3587F3E0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__367C1819");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_Profile__0E6E26BF");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__0F624AF8");
            });

            modelBuilder.Entity<AspnetRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_Roles__17F790F9")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName })
                    .HasName("aspnet_Roles_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__18EBB532");
            });

            modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_SchemaVer__6EF57B66");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_Users__693CA210")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
                    .HasName("aspnet_Users_Index2");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
                    .HasName("aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__6A30C649");
            });

            modelBuilder.Entity<AspnetUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_UsersInRo__1BC821DD");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("aspnet_UsersInRoles_index");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__1DB06A4F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__1CBC4616");
            });

            modelBuilder.Entity<AspnetWebEventEvents>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_WebEvent___45BE5BA9");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.FileId, e.AttachmentId })
                    .HasName("_dta_index_Attachment_12_1191675293__K1_3_5");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Benefit>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_Benefit_Name")
                    .IsUnique();

                entity.Property(e => e.BenefitId).HasColumnName("BenefitID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BenefitItemC>(entity =>
            {
                entity.HasKey(e => e.BenefitItemId);

                entity.HasIndex(e => new { e.CompetitiveGroupId, e.EntranceTestItemId })
                    .HasName("_dta_index_BenefitItemC_12_733245667__K8_K2");

                entity.Property(e => e.BenefitItemId).HasColumnName("BenefitItemID");

                entity.Property(e => e.BenefitId).HasColumnName("BenefitID");

                entity.Property(e => e.BenefitItemGuid).HasColumnName("BenefitItemGUID");

                entity.Property(e => e.CompetitiveGroupId).HasColumnName("CompetitiveGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntranceTestItemId).HasColumnName("EntranceTestItemID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OlympicDiplomTypeId).HasColumnName("OlympicDiplomTypeID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Benefit)
                    .WithMany(p => p.BenefitItemC)
                    .HasForeignKey(d => d.BenefitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitItemC_Benefit");

                entity.HasOne(d => d.CompetitiveGroup)
                    .WithMany(p => p.BenefitItemC)
                    .HasForeignKey(d => d.CompetitiveGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitItemC_CompetitiveGroup");

                entity.HasOne(d => d.EntranceTestItem)
                    .WithMany(p => p.BenefitItemC)
                    .HasForeignKey(d => d.EntranceTestItemId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BenefitItem_EntranceTestItemC");

                entity.HasOne(d => d.OlympicDiplomType)
                    .WithMany(p => p.BenefitItemC)
                    .HasForeignKey(d => d.OlympicDiplomTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitItemC_OlympicDiplomType");
            });

            modelBuilder.Entity<BenefitItemColympicType>(entity =>
            {
                entity.ToTable("BenefitItemCOlympicType");

                entity.HasIndex(e => new { e.BenefitItemId, e.OlympicTypeId })
                    .HasName("UK_BenefitItemCOlympicType")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BenefitItemId).HasColumnName("BenefitItemID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OlympicTypeId).HasColumnName("OlympicTypeID");

                entity.HasOne(d => d.BenefitItem)
                    .WithMany(p => p.BenefitItemColympicType)
                    .HasForeignKey(d => d.BenefitItemId)
                    .HasConstraintName("FK_BenefitItemCOlympicType_BenefitItemC");

                entity.HasOne(d => d.OlympicType)
                    .WithMany(p => p.BenefitItemColympicType)
                    .HasForeignKey(d => d.OlympicTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitItemCOlympicType_OlympicType");
            });

            modelBuilder.Entity<BenefitItemSubject>(entity =>
            {
                entity.HasOne(d => d.BenefitItem)
                    .WithMany(p => p.BenefitItemSubject)
                    .HasForeignKey(d => d.BenefitItemId)
                    .HasConstraintName("FK_BenefitItemSubject_BenefitItemC1");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.BenefitItemSubject)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitItemSubject_Subject1");
            });

            modelBuilder.Entity<BlkApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_Application");

                entity.Property(e => e.ApplicationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntrantUid)
                    .IsRequired()
                    .HasColumnName("EntrantUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsRequiresBudgetOz).HasColumnName("IsRequiresBudgetOZ");

                entity.Property(e => e.IsRequiresPaidOz).HasColumnName("IsRequiresPaidOZ");

                entity.Property(e => e.IsRequiresTargetOz).HasColumnName("IsRequiresTargetOZ");

                entity.Property(e => e.LastDenyDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalDocumentsReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.StatusDecision).IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlkApplicationCompetitiveGroupItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_ApplicationCompetitiveGroupItem");

                entity.Property(e => e.ApplicationUid)
                    .IsRequired()
                    .HasColumnName("ApplicationUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompetitiveGroupItemUid)
                    .HasColumnName("CompetitiveGroupItemUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompetitiveGroupTargetUid)
                    .HasColumnName("CompetitiveGroupTargetUID")
                    .HasMaxLength(200);

                entity.Property(e => e.CompetitivegroupUid)
                    .HasColumnName("CompetitivegroupUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlkApplicationEntranceTestDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_ApplicationEntranceTestDocument");

                entity.HasIndex(e => e.BenefitEntrantDocumentId)
                    .HasName("idx_BenefitEntrantDocumentId");

                entity.HasIndex(e => e.Id)
                    .HasName("Id")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.ImportPackageId)
                    .HasName("idx_PackageId");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_ParentId");

                entity.HasIndex(e => new { e.ImportPackageId, e.InstitutionId })
                    .HasName("idx_PackageInstitutionId");

                entity.Property(e => e.CompetitiveGroupUid)
                    .HasColumnName("CompetitiveGroupUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EgeDocumentId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionDocumentDate).HasColumnType("datetime");

                entity.Property(e => e.InstitutionDocumentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultValue).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlkApplicationIndividualAchievements>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_ApplicationIndividualAchievements");

                entity.Property(e => e.ApplicationUid)
                    .IsRequired()
                    .HasColumnName("ApplicationUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntrantDocumentUid)
                    .IsRequired()
                    .HasColumnName("EntrantDocumentUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iamark)
                    .HasColumnName("IAMark")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Ianame)
                    .IsRequired()
                    .HasColumnName("IAName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Iauid)
                    .HasColumnName("IAUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlkApplicationSelectedCompetitiveGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_ApplicationSelectedCompetitiveGroup");

                entity.HasIndex(e => e.ImportPackageId)
                    .HasName("idx_PackageId");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_ParentId");

                entity.HasIndex(e => new { e.ImportPackageId, e.InstitutionId })
                    .HasName("idx_PackageInstitutionId");

                entity.Property(e => e.CalculatedRating).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlkApplicationSelectedCompetitiveGroupItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_ApplicationSelectedCompetitiveGroupItem");

                entity.HasIndex(e => e.ImportPackageId)
                    .HasName("idx_PackageId");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_ParentId");

                entity.HasIndex(e => new { e.ImportPackageId, e.InstitutionId })
                    .HasName("idx_PackageInstitutionId");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlkApplicationSelectedCompetitiveGroupTarget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_ApplicationSelectedCompetitiveGroupTarget");

                entity.HasIndex(e => e.ImportPackageId)
                    .HasName("idx_PackageId");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_ParentId");

                entity.HasIndex(e => new { e.ImportPackageId, e.InstitutionId })
                    .HasName("idx_PackageInstitutionId");

                entity.Property(e => e.IsForOz).HasColumnName("IsForOZ");

                entity.Property(e => e.TargetOrganizationUid)
                    .HasColumnName("TargetOrganizationUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlkConsideredApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_ConsideredApplication");

                entity.Property(e => e.ApplicationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.EducationFormId).HasColumnName("EducationFormID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.FinanceSourceId).HasColumnName("FinanceSourceID");

                entity.Property(e => e.IsRequiresBudgetOz).HasColumnName("IsRequiresBudgetOZ");

                entity.Property(e => e.IsRequiresPaidOz).HasColumnName("IsRequiresPaidOZ");

                entity.Property(e => e.IsRequiresTargetOz).HasColumnName("IsRequiresTargetOZ");

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlkEntrant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_Entrant");

                entity.HasIndex(e => e.ImportPackageId)
                    .HasName("idx_PackageId");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_ParentId");

                entity.HasIndex(e => new { e.ImportPackageId, e.InstitutionId })
                    .HasName("idx_PackageInstitutionId");

                entity.Property(e => e.CustomInformation).IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Snils)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlkEntrantDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_EntrantDocument");

                entity.HasIndex(e => e.ImportPackageId)
                    .HasName("idx_PackageId");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_ParentId");

                entity.HasIndex(e => new { e.Id, e.ImportPackageId })
                    .HasName("idx_ImportPackageId");

                entity.HasIndex(e => new { e.ImportPackageId, e.DocumentTypeId })
                    .HasName("idx_PackageDocumentTypeId");

                entity.HasIndex(e => new { e.ImportPackageId, e.InstitutionId })
                    .HasName("idx_PackageInstitutionId");

                entity.HasIndex(e => new { e.Id, e.ParentId, e.EntranceTestResultId })
                    .HasName("idx_EntranceTestResultId");

                entity.HasIndex(e => new { e.ParentId, e.ImportPackageId, e.OriginalReceivedDate })
                    .HasName("idx_OriginalReceivedDate");

                entity.HasIndex(e => new { e.DocumentNumber, e.DocumentDate, e.ParentId, e.Id, e.Uid, e.DocumentOrganization, e.DocumentSeries, e.DocumentTypeId, e.ImportPackageId })
                    .HasName("idx_DocumentTypeId");

                entity.HasIndex(e => new { e.DocumentDate, e.DocumentOrganization, e.InstitutionId, e.Uid, e.DocumentNumber, e.DocumentSeries, e.Id, e.ParentId, e.DocumentTypeId, e.ImportPackageId })
                    .HasName("idx_DocumentType");

                entity.Property(e => e.AdditionalInfo).IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentOrganization)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentSeries)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentSpecificData)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeNameText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Gpa).HasColumnName("GPA");

                entity.Property(e => e.OlympicDate).HasColumnType("datetime");

                entity.Property(e => e.OlympicPlace)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubdivisionCode)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlkEntrantDocumentEgeAndOlympicSubject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_EntrantDocumentEgeAndOlympicSubject");

                entity.HasIndex(e => e.ImportPackageId)
                    .HasName("PackageId");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_ParentId");

                entity.HasIndex(e => new { e.ImportPackageId, e.InstitutionId })
                    .HasName("idx_PackageInstitutionId");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<BlkRecommendedApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_RecommendedApplication");

                entity.Property(e => e.ApplicationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.EducationFormId).HasColumnName("EducationFormID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.FinanceSourceId).HasColumnName("FinanceSourceID");

                entity.Property(e => e.IsRequiresBudgetOz).HasColumnName("IsRequiresBudgetOZ");

                entity.Property(e => e.IsRequiresPaidOz).HasColumnName("IsRequiresPaidOZ");

                entity.Property(e => e.IsRequiresTargetOz).HasColumnName("IsRequiresTargetOZ");

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlkRecommendedList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("blk_RecommendedList");

                entity.Property(e => e.ApplicationNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompetitiveGroupUid)
                    .IsRequired()
                    .HasColumnName("CompetitiveGroupUID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkAdmissionVolume>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_AdmissionVolume");

                entity.Property(e => e.AdmissionItemTypeId).HasColumnName("AdmissionItemTypeID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.NumberBudgetOz).HasColumnName("NumberBudgetOZ");

                entity.Property(e => e.NumberPaidOz).HasColumnName("NumberPaidOZ");

                entity.Property(e => e.NumberQuotaOz).HasColumnName("NumberQuotaOZ");

                entity.Property(e => e.NumberTargetOz).HasColumnName("NumberTargetOZ");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId);

                entity.ToTable("bulk_Application");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ApplicationGuid).HasColumnName("ApplicationGUID");

                entity.Property(e => e.ApplicationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntrantId).HasColumnName("EntrantID");

                entity.Property(e => e.EntrantUid)
                    .HasColumnName("EntrantUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.IsRequiresBudgetOz).HasColumnName("IsRequiresBudgetOZ");

                entity.Property(e => e.IsRequiresPaidOz).HasColumnName("IsRequiresPaidOZ");

                entity.Property(e => e.IsRequiresTargetOz).HasColumnName("IsRequiresTargetOZ");

                entity.Property(e => e.LastCheckDate).HasColumnType("datetime");

                entity.Property(e => e.LastDenyDate).HasColumnType("datetime");

                entity.Property(e => e.LastEgeDocumentsCheckDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderCalculatedBenefitId).HasColumnName("OrderCalculatedBenefitID");

                entity.Property(e => e.OrderCalculatedRating)
                    .HasColumnType("decimal(10, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderCompetitiveGroupId).HasColumnName("OrderCompetitiveGroupID");

                entity.Property(e => e.OrderCompetitiveGroupItemId).HasColumnName("OrderCompetitiveGroupItemID");

                entity.Property(e => e.OrderCompetitiveGroupTargetId).HasColumnName("OrderCompetitiveGroupTargetID");

                entity.Property(e => e.OrderEducationFormId).HasColumnName("OrderEducationFormID");

                entity.Property(e => e.OrderEducationSourceId).HasColumnName("OrderEducationSourceID");

                entity.Property(e => e.OrderOfAdmissionId).HasColumnName("OrderOfAdmissionID");

                entity.Property(e => e.OriginalDocumentsReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SourceId)
                    .HasColumnName("SourceID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusDecision).IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ViolationErrors).IsUnicode(false);

                entity.Property(e => e.ViolationId).HasColumnName("ViolationID");

                entity.Property(e => e.WizardStepId).HasColumnName("WizardStepID");
            });

            modelBuilder.Entity<BulkApplicationCompetitiveGroupItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_ApplicationCompetitiveGroupItem");

                entity.Property(e => e.CompetitiveGroupId).HasColumnName("CompetitiveGroupID");

                entity.Property(e => e.CompetitiveGroupItemId).HasColumnName("CompetitiveGroupItemID");

                entity.Property(e => e.CompetitiveGroupTargetId).HasColumnName("CompetitiveGroupTargetID");
            });

            modelBuilder.Entity<BulkApplicationEntranceTestDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_ApplicationEntranceTestDocument");

                entity.Property(e => e.CompetitiveGroupId).HasColumnName("CompetitiveGroupID");

                entity.Property(e => e.EgeDocumentId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EntranceTestItemId).HasColumnName("EntranceTestItemID");

                entity.Property(e => e.EtentrantDocumentId).HasColumnName("ETEntrantDocumentId");

                entity.Property(e => e.InstitutionDocumentDate).HasColumnType("datetime");

                entity.Property(e => e.InstitutionDocumentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultValue).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkApplicationIndividualAchievements>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_ApplicationIndividualAchievements");

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.EntrantDocumentUid)
                    .IsRequired()
                    .HasColumnName("EntrantDocumentUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iamark)
                    .HasColumnName("IAMark")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Ianame)
                    .HasColumnName("IAName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Iauid)
                    .HasColumnName("IAUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionArchievementId).HasColumnName("InstitutionArchievementID");
            });

            modelBuilder.Entity<BulkApplicationSelectedCompetitiveGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_ApplicationSelectedCompetitiveGroup");

                entity.Property(e => e.CalculatedRating).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.CompetitiveGroupId).HasColumnName("CompetitiveGroupID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkApplicationSelectedCompetitiveGroupItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_ApplicationSelectedCompetitiveGroupItem");

                entity.Property(e => e.CompetitiveGroupItemId).HasColumnName("CompetitiveGroupItemID");
            });

            modelBuilder.Entity<BulkApplicationSelectedCompetitiveGroupTarget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_ApplicationSelectedCompetitiveGroupTarget");

                entity.Property(e => e.CompetitiveGroupTargetId).HasColumnName("CompetitiveGroupTargetID");

                entity.Property(e => e.IsForOz).HasColumnName("IsForOZ");
            });

            modelBuilder.Entity<BulkBenefitItemC>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_BenefitItemC");

                entity.Property(e => e.BenefitId).HasColumnName("BenefitID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.OlympicDiplomTypeId).HasColumnName("OlympicDiplomTypeID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkBenefitItemData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_BenefitItemData");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.OlympicTypeId).HasColumnName("OlympicTypeID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<BulkCampaign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_Campaign");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkCampaignDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_CampaignDate");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateOrder).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.EducationFormId).HasColumnName("EducationFormID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.EducationSourceId).HasColumnName("EducationSourceID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkCompetitiveGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_CompetitiveGroup");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkCompetitiveGroupItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_CompetitiveGroupItem");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.NumberBudgetOz).HasColumnName("NumberBudgetOZ");

                entity.Property(e => e.NumberPaidOz).HasColumnName("NumberPaidOZ");

                entity.Property(e => e.NumberQuotaOz).HasColumnName("NumberQuotaOZ");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkCompetitiveGroupTarget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_CompetitiveGroupTarget");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkCompetitiveGroupTargetItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_CompetitiveGroupTargetItem");

                entity.Property(e => e.CompetitiveGroupItemGuid).HasColumnName("CompetitiveGroupItemGUID");

                entity.Property(e => e.CompetitiveGroupItemId).HasColumnName("CompetitiveGroupItemID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.NumberTargetOz).HasColumnName("NumberTargetOZ");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_Delete");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BulkDistributedAdmissionVolume>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_DistributedAdmissionVolume");

                entity.Property(e => e.AdmissionVolumeGuid).HasColumnName("AdmissionVolumeGUID");

                entity.Property(e => e.AdmissionVolumeId).HasColumnName("AdmissionVolumeID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.NumberBudgetOz).HasColumnName("NumberBudgetOZ");

                entity.Property(e => e.NumberQuotaOz).HasColumnName("NumberQuotaOZ");

                entity.Property(e => e.NumberTargetOz).HasColumnName("NumberTargetOZ");
            });

            modelBuilder.Entity<BulkEntranceTestItemC>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_EntranceTestItemC");

                entity.Property(e => e.EntranceTestTypeId).HasColumnName("EntranceTestTypeID");

                entity.Property(e => e.Form)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.MinScore).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkEntrant>(entity =>
            {
                entity.HasKey(e => e.EntrantId);

                entity.ToTable("bulk_Entrant");

                entity.Property(e => e.EntrantId).HasColumnName("EntrantID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomInformation).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EntrantGuid).HasColumnName("EntrantGUID");

                entity.Property(e => e.FactAddressId).HasColumnName("FactAddressID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.IdentityDocumentId).HasColumnName("IdentityDocumentID");

                entity.Property(e => e.ImportPackageId).HasColumnName("ImportPackageID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationAddressId).HasColumnName("RegistrationAddressID");

                entity.Property(e => e.Snils)
                    .HasColumnName("SNILS")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkEntrantDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_EntrantDocument");

                entity.HasIndex(e => new { e.Id, e.ParentId, e.OriginalReceivedDate, e.ImportPackageId })
                    .HasName("IDX_BulkEntrantDocument_ImportPackageId");

                entity.HasIndex(e => new { e.DocumentNumber, e.DocumentDate, e.DocumentOrganization, e.DocumentSeries, e.DocumentTypeId, e.DocumentSpecificData, e.Uid, e.Id, e.ParentId, e.ImportPackageId })
                    .HasName("IDX_BulkEntrantDocument_ParentId_ImportPackageId");

                entity.Property(e => e.AdditionalInfo).IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentOrganization)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentSeries)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentSpecificData)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.DocumentTypeNameText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.Gpa).HasColumnName("GPA");

                entity.Property(e => e.InstitutionName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OlympicDate).HasColumnType("datetime");

                entity.Property(e => e.OlympicPlace)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.QualificationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialityName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubdivisionCode)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkEntrantDocumentSubject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_EntrantDocumentSubject");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkInstitutionAchievements>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_InstitutionAchievements");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.MaxValue).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Name)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkOrderOfAdmission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulk_OrderOfAdmission");

                entity.Property(e => e.ApplicationCgitemId).HasColumnName("ApplicationCGItemID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ApplicationLevelBudgetId).HasColumnName("ApplicationLevelBudgetID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.EducationFormId).HasColumnName("EducationFormID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.FinanceSourceId).HasColumnName("FinanceSourceID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDatePublished).HasColumnType("datetime");

                entity.Property(e => e.OrderName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.HasIndex(e => e.YearStart)
                    .HasName("IX_Campaign_StartYear");

                entity.HasIndex(e => new { e.YearEnd, e.EducationFormFlag, e.StatusId, e.ModifiedDate, e.YearStart, e.InstitutionId, e.Name, e.CampaignId })
                    .HasName("_dta_index_Campaign_12_1519344477__K2_K3_K1_4_5_6_7_10");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CampaignGuid).HasColumnName("CampaignGUID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Campaign)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_Campaign_Institution");
            });

            modelBuilder.Entity<CampaignDate>(entity =>
            {
                entity.HasIndex(e => new { e.CampaignDateId, e.Stage, e.DateStart, e.DateEnd, e.DateOrder, e.Uid, e.CampaignId, e.Course, e.IsActive, e.EducationFormId, e.EducationLevelId, e.EducationSourceId })
                    .HasName("_dta_index_CampaignDate_12_1631344876__K2_K3_K10_K5_K4_K12_1_6_7_8_9_11");

                entity.Property(e => e.CampaignDateId).HasColumnName("CampaignDateID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateOrder).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.EducationFormId).HasColumnName("EducationFormID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.EducationSourceId).HasColumnName("EducationSourceID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.CampaignDate)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK_CampaignDate_Campaign");

                entity.HasOne(d => d.EducationForm)
                    .WithMany(p => p.CampaignDateEducationForm)
                    .HasForeignKey(d => d.EducationFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CampaignDate_AdmissionItemTypeForm");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.CampaignDateEducationLevel)
                    .HasForeignKey(d => d.EducationLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CampaignDate_AdmissionItemTypeLevel");

                entity.HasOne(d => d.EducationSource)
                    .WithMany(p => p.CampaignDateEducationSource)
                    .HasForeignKey(d => d.EducationSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CampaignDate_AdmissionItemTypeSource");
            });

            modelBuilder.Entity<CampaignEducationLevel>(entity =>
            {
                entity.HasIndex(e => new { e.CampaignEducationLevelId, e.Course, e.EducationLevelId, e.CampaignId })
                    .HasName("_dta_index_CampaignEducationLevel_12_1567344648__K2_1_3_4");

                entity.Property(e => e.CampaignEducationLevelId).HasColumnName("CampaignEducationLevelID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.CampaignEducationLevel)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK_CampaignEducationLevel_Campaign");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.CampaignEducationLevel)
                    .HasForeignKey(d => d.EducationLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CampaignEducationLevel_AdmissionItemType");
            });

            modelBuilder.Entity<CampaignOrderDateCatalog>(entity =>
            {
                entity.HasKey(e => e.YearStart);

                entity.Property(e => e.YearStart).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.PaidOrderDate).HasColumnType("date");

                entity.Property(e => e.Stage1OrderDate).HasColumnType("date");

                entity.Property(e => e.Stage2OrderDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TargetOrderDate).HasColumnType("date");
            });

            modelBuilder.Entity<CampaignStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__Campaign__C8EE20437C9A5A9E");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CityType>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.HasIndex(e => new { e.OkatoCode, e.OkatoModified })
                    .HasName("IX_CityType_Okato");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OkatoCode)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OkatoModified).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<CompetitiveGroup>(entity =>
            {
                entity.HasIndex(e => e.Course)
                    .HasName("_dta_index_CompetitiveGroup_12_1152723159__K4");

                entity.HasIndex(e => e.InstitutionId)
                    .HasName("_dta_index_CompetitiveGroup_12_1152723159__K2");

                entity.HasIndex(e => new { e.Name, e.CompetitiveGroupId })
                    .HasName("_dta_index_CompetitiveGroup_12_1152723159__K1_3_9987");

                entity.HasIndex(e => new { e.Uid, e.InstitutionId });

                entity.HasIndex(e => new { e.InstitutionId, e.Name, e.CampaignId })
                    .HasName("UK_CompetitiveGroup_UniqueInstitutionName")
                    .IsUnique();

                entity.HasIndex(e => new { e.CampaignId, e.Course, e.InstitutionId, e.CompetitiveGroupId, e.Name })
                    .HasName("_dta_index_CompetitiveGroup_12_1152723159__K2_K1_K3_4_9");

                entity.HasIndex(e => new { e.Name, e.Course, e.InstitutionId, e.CampaignId, e.CompetitiveGroupId })
                    .HasName("_dta_index_CompetitiveGroup_12_1152723159__K2_K9_K1_3_4");

                entity.HasIndex(e => new { e.DirectionFilterType, e.Course, e.Uid, e.Name, e.InstitutionId, e.CreatedDate, e.ModifiedDate, e.CampaignId, e.CompetitiveGroupId })
                    .HasName("_dta_index_CompetitiveGroup_12_1152723159__K1_2_3_4_6_7_8_9_10");

                entity.Property(e => e.CompetitiveGroupId).HasColumnName("CompetitiveGroupID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CompetitiveGroupGuid).HasColumnName("CompetitiveGroupGUID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.CompetitiveGroup)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK_CompetitiveGroup_Campaign");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.CompetitiveGroup)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetitiveGroup_Institution");
            });

            modelBuilder.Entity<CompetitiveGroupItem>(entity =>
            {
                entity.HasKey(e => e.CompetitiveGroupItemId)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CompetitiveGroupItemId, e.EducationLevelId })
                    .HasName("_dta_index_CompetitiveGroupItem_12_1216723387__K1_K13");

                entity.HasIndex(e => new { e.CompetitiveGroupItemId, e.Uid })
                    .HasName("IX_CompetitiveGroupItem_UID");

                entity.HasIndex(e => new { e.CompetitiveGroupId, e.DirectionId, e.EducationLevelId })
                    .HasName("UK_CompetitiveGroupItem")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.CompetitiveGroupItemId, e.CompetitiveGroupId, e.NumberBudgetOz, e.NumberBudgetZ, e.NumberPaidO, e.NumberPaidOz, e.NumberPaidZ, e.NumberBudgetO })
                    .HasName("_dta_index_CompetitiveGroupItem_12_1216723387__K2_K5_K6_K7_K8_K9_K4_1");

                entity.Property(e => e.CompetitiveGroupItemId).HasColumnName("CompetitiveGroupItemID");

                entity.Property(e => e.CompetitiveGroupId).HasColumnName("CompetitiveGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NumberBudgetOz).HasColumnName("NumberBudgetOZ");

                entity.Property(e => e.NumberPaidOz).HasColumnName("NumberPaidOZ");

                entity.Property(e => e.NumberQuotaOz).HasColumnName("NumberQuotaOZ");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CompetitiveGroup)
                    .WithMany(p => p.CompetitiveGroupItem)
                    .HasForeignKey(d => d.CompetitiveGroupId)
                    .HasConstraintName("FK_CompetitiveGroupItem_CompetitiveGroup");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.CompetitiveGroupItem)
                    .HasForeignKey(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetitiveGroupItem_Direction");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.CompetitiveGroupItem)
                    .HasForeignKey(d => d.EducationLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetitiveGroupItem_EducationLevelID");
            });

            modelBuilder.Entity<CompetitiveGroupTarget>(entity =>
            {
                entity.HasKey(e => e.CompetitiveGroupTargetId)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CompetitiveGroupTargetId, e.InstitutionId })
                    .HasName("_dta_index_CompetitiveGroupTarget_c_12_1296723672__K1_K7")
                    .IsClustered();

                entity.HasIndex(e => new { e.CompetitiveGroupTargetId, e.Uid, e.InstitutionId })
                    .HasName("idx_UIDInstitutionID");

                entity.Property(e => e.CompetitiveGroupTargetId).HasColumnName("CompetitiveGroupTargetID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.CompetitiveGroupTarget)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetitiveGroupTarget_Institution");
            });

            modelBuilder.Entity<CompetitiveGroupTargetItem>(entity =>
            {
                entity.HasKey(e => e.CompetitiveGroupTargetItemId)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CompetitiveGroupItemId, e.CompetitiveGroupTargetId })
                    .HasName("UK_CompetitiveGroupTargetItem")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.NumberTargetO, e.CompetitiveGroupItemId })
                    .HasName("_dta_index_CompetitiveGroupTargetItem_12_1360723900__K3_8");

                entity.HasIndex(e => new { e.NumberTargetOz, e.CompetitiveGroupItemId })
                    .HasName("_dta_index_CompetitiveGroupTargetItem_12_1360723900__K3_9");

                entity.HasIndex(e => new { e.CompetitiveGroupTargetId, e.NumberTargetZ, e.CompetitiveGroupItemId })
                    .HasName("_dta_index_CompetitiveGroupTargetItem_12_1360723900__K3_2_10");

                entity.HasIndex(e => new { e.NumberTargetO, e.NumberTargetOz, e.NumberTargetZ, e.CompetitiveGroupItemId })
                    .HasName("_dta_index_CompetitiveGroupTargetItem_12_1360723900__K3_8_9_10");

                entity.Property(e => e.CompetitiveGroupTargetItemId).HasColumnName("CompetitiveGroupTargetItemID");

                entity.Property(e => e.CompetitiveGroupItemId).HasColumnName("CompetitiveGroupItemID");

                entity.Property(e => e.CompetitiveGroupTargetId).HasColumnName("CompetitiveGroupTargetID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NumberTargetOz).HasColumnName("NumberTargetOZ");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CompetitiveGroupItem)
                    .WithMany(p => p.CompetitiveGroupTargetItem)
                    .HasForeignKey(d => d.CompetitiveGroupItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetitiveGroupTargetItem_CompetitiveGroupItem");

                entity.HasOne(d => d.CompetitiveGroupTarget)
                    .WithMany(p => p.CompetitiveGroupTargetItem)
                    .HasForeignKey(d => d.CompetitiveGroupTargetId)
                    .HasConstraintName("FK_CompetitiveGroupTargetItem_CompetitiveGroupTarget");
            });

            modelBuilder.Entity<CompositionThemes>(entity =>
            {
                entity.HasKey(e => e.ThemeId)
                    .HasName("PK__Composit__FBB3E4B92E66C05C");

                entity.HasComment("Темы сочинений");

                entity.Property(e => e.ThemeId)
                    .HasColumnName("ThemeID")
                    .HasComment("ИД записи");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasComment("Название темы сочинения");
            });

            modelBuilder.Entity<CompositionThemesApprob>(entity =>
            {
                entity.HasKey(e => e.ThemeId);

                entity.ToTable("CompositionThemes_Approb");

                entity.Property(e => e.ThemeId)
                    .HasColumnName("ThemeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CountryType>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.HasIndex(e => e.Alfa2Code)
                    .HasName("UX_CountryType_Alfa2Code")
                    .IsUnique();

                entity.HasIndex(e => e.Alfa3Code)
                    .HasName("UX_CountryType_Alfa3Code")
                    .IsUnique();

                entity.HasIndex(e => e.DigitCode)
                    .HasName("UX_CountryType_DigitCode")
                    .IsUnique();

                entity.HasIndex(e => new { e.DisplayOrder, e.Name })
                    .HasName("UX_CountryType")
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Alfa2Code)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Alfa3Code)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DigitCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CourseSubject>(entity =>
            {
                entity.HasIndex(e => new { e.PreparatoryCourseId, e.SubjectName })
                    .HasName("UK_CourseSubject")
                    .IsUnique();

                entity.Property(e => e.CourseSubjectId).HasColumnName("CourseSubjectID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PreparatoryCourseId).HasColumnName("PreparatoryCourseID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PreparatoryCourse)
                    .WithMany(p => p.CourseSubject)
                    .HasForeignKey(d => d.PreparatoryCourseId)
                    .HasConstraintName("FK_CourseSubject_PreparatoryCourse");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.CourseSubject)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_CourseSubject_Subject");
            });

            modelBuilder.Entity<CourseType>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.Property(e => e.CourseId)
                    .HasColumnName("CourseID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Direction>(entity =>
            {
                entity.HasKey(e => e.DirectionId)
                    .IsClustered(false);

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EduDirectory)
                    .HasColumnName("EDU_DIRECTORY")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Edulevel)
                    .HasColumnName("EDULEVEL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EduprAdditional)
                    .HasColumnName("EDUPR_ADDITIONAL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Eduprogramtype)
                    .HasColumnName("EDUPROGRAMTYPE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NewCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Period)
                    .HasColumnName("PERIOD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qualificationcode)
                    .HasColumnName("QUALIFICATIONCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qualificationname)
                    .HasColumnName("QUALIFICATIONNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SysGuid)
                    .HasColumnName("SYS_GUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ugscode)
                    .HasColumnName("UGSCODE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ugsname)
                    .HasColumnName("UGSNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Direction)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Direction_ParentDirection");
            });

            modelBuilder.Entity<DirectionSubjectLink>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileSubjectId).HasColumnName("ProfileSubjectID");

                entity.HasOne(d => d.ProfileSubject)
                    .WithMany(p => p.DirectionSubjectLink)
                    .HasForeignKey(d => d.ProfileSubjectId)
                    .HasConstraintName("FK_DirectionSubjectLink_Subject");
            });

            modelBuilder.Entity<DirectionSubjectLinkDirection>(entity =>
            {
                entity.HasIndex(e => e.DirectionId)
                    .HasName("UK_DirectionSubjectLinkDirectionDirectionID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Direction)
                    .WithOne(p => p.DirectionSubjectLinkDirection)
                    .HasForeignKey<DirectionSubjectLinkDirection>(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectionSubjectLinkDirection_Direction");

                entity.HasOne(d => d.Link)
                    .WithMany(p => p.DirectionSubjectLinkDirection)
                    .HasForeignKey(d => d.LinkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectionSubjectLinkDirection_DirectionSubjectLink");
            });

            modelBuilder.Entity<DirectionSubjectLinkSubject>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Link)
                    .WithMany(p => p.DirectionSubjectLinkSubject)
                    .HasForeignKey(d => d.LinkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectionSubjectLinkSubject_DirectionSubjectLink");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.DirectionSubjectLinkSubject)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectionSubjectLinkSubject_Subject");
            });

            modelBuilder.Entity<DirectionTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Direction_tmp");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.EduDirectory)
                    .HasColumnName("EDU_DIRECTORY")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Edulevel)
                    .HasColumnName("EDULEVEL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EduprAdditional)
                    .HasColumnName("EDUPR_ADDITIONAL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Eduprogramtype)
                    .HasColumnName("EDUPROGRAMTYPE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NewCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Period)
                    .HasColumnName("PERIOD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qualificationcode)
                    .HasColumnName("QUALIFICATIONCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qualificationname)
                    .HasColumnName("QUALIFICATIONNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SysGuid)
                    .HasColumnName("SYS_GUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ugscode)
                    .HasColumnName("UGSCODE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ugsname)
                    .HasColumnName("UGSNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DisabilityType>(entity =>
            {
                entity.HasKey(e => e.DisabilityId);

                entity.Property(e => e.DisabilityId)
                    .HasColumnName("DisabilityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DistributedAdmissionVolume>(entity =>
            {
                entity.Property(e => e.DistributedAdmissionVolumeId).HasColumnName("DistributedAdmissionVolumeID");

                entity.Property(e => e.AdmissionVolumeId).HasColumnName("AdmissionVolumeID");

                entity.Property(e => e.NumberBudgetOz).HasColumnName("NumberBudgetOZ");

                entity.Property(e => e.NumberQuotaOz).HasColumnName("NumberQuotaOZ");

                entity.Property(e => e.NumberTargetOz).HasColumnName("NumberTargetOZ");

                entity.HasOne(d => d.AdmissionVolume)
                    .WithMany(p => p.DistributedAdmissionVolume)
                    .HasForeignKey(d => d.AdmissionVolumeId)
                    .HasConstraintName("FK_DistributedAdmissionVolume_AdmissionVolume");

                entity.HasOne(d => d.IdLevelBudgetNavigation)
                    .WithMany(p => p.DistributedAdmissionVolume)
                    .HasForeignKey(d => d.IdLevelBudget)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DistributedAdmissionVolume_LevelBudget");
            });

            modelBuilder.Entity<DocumentCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Document__19093A2B1F247CCC");

                entity.HasComment("Справочник категорий документов");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasComment("ИД категории документов");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Наименование категории документов");
            });

            modelBuilder.Entity<DocumentCheckStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__Document__C8EE204378C9C9BA");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.Property(e => e.DocumentId)
                    .HasColumnName("DocumentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DocumentType)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentType_DocumentCategory");
            });

            modelBuilder.Entity<EduLevelDocumentType>(entity =>
            {
                entity.HasComment("Типы документов, необходимые для поступления на уровень образования");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ИД записи");

                entity.Property(e => e.DocumentTypeId).HasComment("Тип документа FK (Document¬Type – Document¬ID)");

                entity.Property(e => e.LevelId)
                    .HasColumnName("LevelID")
                    .HasComment("Уровень образования FK (EduLevels – LevelID)");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.EduLevelDocumentType)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduLevelDocumentType_DocumentType");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.EduLevelDocumentType)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduLevelDocumentType_EduLevels");
            });

            modelBuilder.Entity<EduLevels>(entity =>
            {
                entity.HasKey(e => e.LevelId)
                    .HasName("PK__EduLevel__09F03C0622F50DB0");

                entity.HasComment("Справочник уровней образования");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.AdmissionItemTypeId)
                    .HasColumnName("AdmissionItemTypeID")
                    .HasComment("Ссылка на уровень образования из AdmissionItemType FK (AdmissionItemType – ItemTypeID)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Наименование уровня образования");

                entity.HasOne(d => d.AdmissionItemType)
                    .WithMany(p => p.EduLevels)
                    .HasForeignKey(d => d.AdmissionItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduLevels_AdmissionItemType");
            });

            modelBuilder.Entity<EntranceTestCreativeDirection>(entity =>
            {
                entity.HasKey(e => e.DirectionId)
                    .HasName("PK_EntranceTestCreativeDirections");

                entity.Property(e => e.DirectionId)
                    .HasColumnName("DirectionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Direction)
                    .WithOne(p => p.EntranceTestCreativeDirection)
                    .HasForeignKey<EntranceTestCreativeDirection>(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntranceTestCreativeDirections_Direction");
            });

            modelBuilder.Entity<EntranceTestItemC>(entity =>
            {
                entity.HasKey(e => e.EntranceTestItemId);

                entity.HasIndex(e => new { e.CompetitiveGroupId, e.SubjectId, e.EntranceTestTypeId, e.SubjectName })
                    .HasName("UK_EntranceTestItemC")
                    .IsUnique();

                entity.Property(e => e.EntranceTestItemId).HasColumnName("EntranceTestItemID");

                entity.Property(e => e.CompetitiveGroupId).HasColumnName("CompetitiveGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntranceTestItemGuid).HasColumnName("EntranceTestItemGUID");

                entity.Property(e => e.EntranceTestTypeId).HasColumnName("EntranceTestTypeID");

                entity.Property(e => e.Form)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MinScore).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CompetitiveGroup)
                    .WithMany(p => p.EntranceTestItemC)
                    .HasForeignKey(d => d.CompetitiveGroupId)
                    .HasConstraintName("FK_EntranceTestItemC_CompetitiveGroupID");

                entity.HasOne(d => d.EntranceTestType)
                    .WithMany(p => p.EntranceTestItemC)
                    .HasForeignKey(d => d.EntranceTestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntranceTestItemC_EntranceTestType");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.EntranceTestItemC)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_EntranceTestItemC_Subject");
            });

            modelBuilder.Entity<EntranceTestProfileDirection>(entity =>
            {
                entity.HasKey(e => e.ProfileDirectionId)
                    .HasName("PK_EntranceTestProfileDirections");

                entity.HasIndex(e => new { e.InstitutionId, e.DirectionId })
                    .HasName("UK_EntranceTestProfileDirections")
                    .IsUnique();

                entity.Property(e => e.ProfileDirectionId).HasColumnName("ProfileDirectionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.EntranceTestProfileDirection)
                    .HasForeignKey(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntranceTestProfileDirections_Direction");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.EntranceTestProfileDirection)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntranceTestProfileDirections_Institution");
            });

            modelBuilder.Entity<EntranceTestResultSource>(entity =>
            {
                entity.HasKey(e => e.SourceId);

                entity.Property(e => e.SourceId)
                    .HasColumnName("SourceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EntranceTestType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_EntranceTestType_Name")
                    .IsUnique();

                entity.Property(e => e.EntranceTestTypeId).HasColumnName("EntranceTestTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Entrant>(entity =>
            {
                entity.HasIndex(e => new { e.EntrantId, e.IdentityDocumentId })
                    .HasName("_dta_index_Entrant_10_804197915__K4_1");

                entity.HasIndex(e => new { e.EntrantId, e.LastName })
                    .HasName("_dta_index_Entrant_12_804197915__K1_K25");

                entity.HasIndex(e => new { e.IdentityDocumentId, e.InstitutionId, e.Uid, e.EntrantId, e.GenderId })
                    .HasName("_dta_index_Entrant_10_804197915__K24_K21_K1_K28_4");

                entity.HasIndex(e => new { e.IdentityDocumentId, e.LastName, e.FirstName, e.MiddleName, e.EntrantId })
                    .HasName("_dta_index_Entrant_12_804197915__K1_4_25_26_27");

                entity.Property(e => e.EntrantId).HasColumnName("EntrantID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomInformation).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EntrantGuid).HasColumnName("EntrantGUID");

                entity.Property(e => e.FactAddressId).HasColumnName("FactAddressID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.IdentityDocumentId).HasColumnName("IdentityDocumentID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonLinkDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationAddressId).HasColumnName("RegistrationAddressID");

                entity.Property(e => e.Snils)
                    .HasColumnName("SNILS")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.FactAddress)
                    .WithMany(p => p.EntrantFactAddress)
                    .HasForeignKey(d => d.FactAddressId)
                    .HasConstraintName("FK_Entrant_Address_Fact");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Entrant)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Entrant_GenderType");

                entity.HasOne(d => d.IdentityDocument)
                    .WithMany(p => p.Entrant)
                    .HasForeignKey(d => d.IdentityDocumentId)
                    .HasConstraintName("FK_Entrant_EntrantDocument");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Entrant)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_Entrant_Institution");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Entrant)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Entrant_RVIPersons");

                entity.HasOne(d => d.RegistrationAddress)
                    .WithMany(p => p.EntrantRegistrationAddress)
                    .HasForeignKey(d => d.RegistrationAddressId)
                    .HasConstraintName("FK_Entrant_Address_Registration");
            });

            modelBuilder.Entity<EntrantDocument>(entity =>
            {
                entity.HasIndex(e => e.AttachmentId)
                    .HasName("IX_EntrantDocument_Attachment");

                entity.HasIndex(e => e.EntrantDocumentGuid)
                    .HasName("idx_EntrantDocumentGUID");

                entity.HasIndex(e => new { e.DocumentNumber, e.EntrantDocumentId })
                    .HasName("_dta_index_EntrantDocument_12_1028198713__K1_5");

                entity.HasIndex(e => new { e.DocumentNumber, e.EntrantDocumentId, e.DocumentSeries })
                    .HasName("_dta_index_EntrantDocument_12_1028198713__K1_K4_5");

                entity.HasIndex(e => new { e.DocumentSeries, e.DocumentNumber, e.EntrantDocumentId })
                    .HasName("_dta_index_EntrantDocument_12_1028198713__K1_4_5");

                entity.HasIndex(e => new { e.DocumentTypeId, e.DocumentSeries, e.DocumentNumber })
                    .HasName("idx_TypeSeriesNumber");

                entity.HasIndex(e => new { e.DocumentNumber, e.DocumentTypeId, e.EntrantDocumentId, e.DocumentSeries })
                    .HasName("_dta_index_EntrantDocument_12_1028198713__K3_K1_K4_5");

                entity.HasIndex(e => new { e.DocumentTypeId, e.DocumentSeries, e.EntrantId, e.DocumentNumber, e.EntrantDocumentId })
                    .HasName("_dta_index_EntrantDocument_12_1028198713__K5_K1_2_3_4");

                entity.HasIndex(e => new { e.EntrantId, e.DocumentTypeId, e.DocumentDate, e.DocumentNumber, e.EntrantDocumentId, e.DocumentSeries })
                    .HasName("_dta_index_EntrantDocument_12_1028198713__K1_K4_2_3_5_6");

                entity.HasIndex(e => new { e.EntrantDocumentId, e.DocumentSeries, e.DocumentDate, e.DocumentNumber, e.DocumentOrganization, e.Uid, e.DocumentTypeId })
                    .HasName("idx_DocumentTypeID");

                entity.HasIndex(e => new { e.DocumentNumber, e.DocumentSeries, e.DocumentDate, e.DocumentOrganization, e.DocumentSpecificData, e.EntrantId, e.DocumentTypeId, e.AttachmentId, e.EntrantDocumentId })
                    .HasName("_dta_index_EntrantDocument_12_1028198713__K2_K3_K9_K1_4_5_6_7_8");

                entity.HasIndex(e => new { e.DocumentSpecificData, e.Uid, e.CreatedDate, e.ModifiedDate, e.DocumentDate, e.DocumentOrganization, e.DocumentSeries, e.DocumentNumber, e.EntrantId, e.DocumentTypeId, e.AttachmentId, e.EntrantDocumentId })
                    .HasName("_dta_index_EntrantDocument_12_1028198713__K2_K3_K9_K1_4_5_6_7_8_10_11_12");

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentOrganization)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentSeries)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentSpecificData)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.EntrantDocumentGuid).HasColumnName("EntrantDocumentGUID");

                entity.Property(e => e.EntrantId).HasColumnName("EntrantID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.EntrantDocument)
                    .HasForeignKey(d => d.AttachmentId)
                    .HasConstraintName("FK_EntrantDocument_Attachment");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.EntrantDocument)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntrantDocument_DocumentType");

                entity.HasOne(d => d.EntrantNavigation)
                    .WithMany(p => p.EntrantDocument)
                    .HasForeignKey(d => d.EntrantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntrantDocument_Entrant");
            });

            modelBuilder.Entity<EntrantDocumentCustom>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.EntrantDocumentId)
                    .HasName("idx_EntrantDocument")
                    .IsClustered();

                entity.Property(e => e.AdditionalInfo).IsUnicode(false);

                entity.Property(e => e.DocumentTypeNameText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.HasOne(d => d.EntrantDocument)
                    .WithMany()
                    .HasForeignKey(d => d.EntrantDocumentId)
                    .HasConstraintName("FK_EntrantDocumentCustom_EntrantDocument");
            });

            modelBuilder.Entity<EntrantDocumentDisability>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.EntrantDocumentId)
                    .HasName("idx_EntrantDocument")
                    .IsClustered();

                entity.Property(e => e.DisabilityTypeId).HasColumnName("DisabilityTypeID");

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.HasOne(d => d.EntrantDocument)
                    .WithMany()
                    .HasForeignKey(d => d.EntrantDocumentId)
                    .HasConstraintName("FK_EntrantDocumentDisability_EntrantDocument");
            });

            modelBuilder.Entity<EntrantDocumentEdu>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.EntrantDocumentId)
                    .HasName("idx_EntrantDocument")
                    .IsClustered();

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.Gpa).HasColumnName("GPA");

                entity.Property(e => e.InstitutionName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.QualificationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialityName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.EntrantDocument)
                    .WithMany()
                    .HasForeignKey(d => d.EntrantDocumentId)
                    .HasConstraintName("FK_EntrantDocumentEdu_EntrantDocument");
            });

            modelBuilder.Entity<EntrantDocumentEge>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.EntrantDocumentId)
                    .HasName("idx_EntrantDocument")
                    .IsClustered();

                entity.Property(e => e.Decision)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DecisionDate).HasColumnType("datetime");

                entity.Property(e => e.DecisionNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.TypographicNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.EntrantDocument)
                    .WithMany()
                    .HasForeignKey(d => d.EntrantDocumentId)
                    .HasConstraintName("FK_EntrantDocumentEge_EntrantDocument");
            });

            modelBuilder.Entity<EntrantDocumentEgeAndOlympicSubject>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.EntrantDocumentId)
                    .HasName("idx_EntrantDocument")
                    .IsClustered();

                entity.Property(e => e.AppealStatusId).HasColumnName("AppealStatusID");

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.AppealStatus)
                    .WithMany()
                    .HasForeignKey(d => d.AppealStatusId)
                    .HasConstraintName("FK_EntrantDocumentEgeAndOlympicSubject_AppealStatus");

                entity.HasOne(d => d.EntrantDocument)
                    .WithMany()
                    .HasForeignKey(d => d.EntrantDocumentId)
                    .HasConstraintName("FK_EntrantDocumentEgeAndOlympicSubject_EntrantDocument");
            });

            modelBuilder.Entity<EntrantDocumentIdentity>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.EntrantDocumentId)
                    .HasName("idx_EntrantDocument")
                    .IsClustered();

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.GenderTypeId).HasColumnName("GenderTypeID");

                entity.Property(e => e.IdentityDocumentTypeId).HasColumnName("IdentityDocumentTypeID");

                entity.Property(e => e.NationalityTypeId).HasColumnName("NationalityTypeID");

                entity.Property(e => e.SubdivisionCode)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.HasOne(d => d.EntrantDocument)
                    .WithMany()
                    .HasForeignKey(d => d.EntrantDocumentId)
                    .HasConstraintName("FK_EntrantDocumentIdentity_EntrantDocument");

                entity.HasOne(d => d.IdentityDocumentType)
                    .WithMany()
                    .HasForeignKey(d => d.IdentityDocumentTypeId)
                    .HasConstraintName("FK_EntrantDocumentIdentity_IdentityDocumentType");

                entity.HasOne(d => d.NationalityType)
                    .WithMany()
                    .HasForeignKey(d => d.NationalityTypeId)
                    .HasConstraintName("FK_EntrantDocumentIdentity_CountryType");
            });

            modelBuilder.Entity<EntrantDocumentIdentityTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EntrantDocumentIdentity_tmp");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.GenderTypeId).HasColumnName("GenderTypeID");

                entity.Property(e => e.IdentityDocumentTypeId).HasColumnName("IdentityDocumentTypeID");

                entity.Property(e => e.NationalityTypeId).HasColumnName("NationalityTypeID");

                entity.Property(e => e.SubdivisionCode)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntrantDocumentMarks>(entity =>
            {
                entity.HasKey(e => e.EntrantDocumentId)
                    .HasName("PK__EntrantD__C54A675C32375140");

                entity.HasComment("Баллы по предметам, указанные в документах абитуриента ");

                entity.Property(e => e.EntrantDocumentId)
                    .HasColumnName("EntrantDocumentID")
                    .HasComment("ИД документа абитуриента FK (EntrantDocument - EntrantDocumentID");

                entity.Property(e => e.SubjectId)
                    .HasColumnName("SubjectID")
                    .HasComment("ИД предмета FK (Subject¬ - Subject¬ID) ");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.EntrantDocumentMarks)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntrantDocumentMarks_Subject");
            });

            modelBuilder.Entity<EntrantDocumentOlympic>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.EntrantDocumentId)
                    .HasName("idx_EntrantDocument")
                    .IsClustered();

                entity.Property(e => e.DiplomaTypeId).HasColumnName("DiplomaTypeID");

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.OlympicId).HasColumnName("OlympicID");

                entity.HasOne(d => d.EntrantDocument)
                    .WithMany()
                    .HasForeignKey(d => d.EntrantDocumentId)
                    .HasConstraintName("FK_EntrantDocumentOlympic_EntrantDocument");
            });

            modelBuilder.Entity<EntrantDocumentOlympicTotal>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.EntrantDocumentId)
                    .HasName("idx_EntrantDocument")
                    .IsClustered();

                entity.Property(e => e.DiplomaTypeId).HasColumnName("DiplomaTypeID");

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.OlympicDate).HasColumnType("datetime");

                entity.Property(e => e.OlympicPlace)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.EntrantDocument)
                    .WithMany()
                    .HasForeignKey(d => d.EntrantDocumentId)
                    .HasConstraintName("FK_EntrantDocumentOlympicTotal_EntrantDocument");
            });

            modelBuilder.Entity<EntrantLanguage>(entity =>
            {
                entity.HasIndex(e => e.EntrantId)
                    .HasName("idx_EntrantID");

                entity.HasIndex(e => new { e.EntrantId, e.LanguageId })
                    .HasName("UK_EntrantLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntrantId).HasColumnName("EntrantID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Entrant)
                    .WithMany(p => p.EntrantLanguage)
                    .HasForeignKey(d => d.EntrantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntrantLanguage_Entrant");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.EntrantLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntrantLanguage_ForeignLanguageType");
            });

            modelBuilder.Entity<FbsToFisMap>(entity =>
            {
                entity.HasOne(d => d.IdSubjectFisNavigation)
                    .WithMany(p => p.FbsToFisMap)
                    .HasForeignKey(d => d.IdSubjectFis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FbsToFisMap_Subject");
            });

            modelBuilder.Entity<ForeignLanguageType>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.HasIndex(e => e.Name)
                    .HasName("UK_ForeignLanguageType_Name")
                    .IsUnique();

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormOfLaw>(entity =>
            {
                entity.HasIndex(e => e.FormOfLawId)
                    .HasName("UK_FormOfLaw_Name")
                    .IsUnique();

                entity.Property(e => e.FormOfLawId).HasColumnName("FormOfLawID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FtcRandDouble>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ftc_RandDouble");
            });

            modelBuilder.Entity<GenderType>(entity =>
            {
                entity.HasKey(e => e.GenderId);

                entity.Property(e => e.GenderId)
                    .HasColumnName("GenderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GlobalMinEge>(entity =>
            {
                entity.HasKey(e => e.EgeYear);

                entity.Property(e => e.EgeYear).ValueGeneratedNever();
            });

            modelBuilder.Entity<IdentityDocumentType>(entity =>
            {
                entity.Property(e => e.IdentityDocumentTypeId)
                    .HasColumnName("IdentityDocumentTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImportPackage>(entity =>
            {
                entity.HasKey(e => e.PackageId);

                entity.HasIndex(e => e.InstitutionId)
                    .HasName("idx_InstitutionID");

                entity.HasIndex(e => e.StatusId)
                    .HasName("idx_StatusID");

                entity.HasIndex(e => new { e.LastDateChanged, e.StatusId, e.PackageData, e.UserLogin, e.PackageId, e.InstitutionId, e.TypeId, e.CreateDate })
                    .HasName("_dta_index_ImportPackage_12_1149247149__K4D_1_2_3_5_6_8_13");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.CheckResultInfo).HasColumnType("xml");

                entity.Property(e => e.CheckStatusId).HasColumnName("CheckStatusID");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImportedAppIds)
                    .HasColumnName("ImportedAppIDs")
                    .HasColumnType("xml");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.LastDateChanged)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PackageData)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.Property(e => e.ProcessResultInfo).HasColumnType("xml");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.ImportPackage)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportPackage_Institution");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ImportPackage)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportPackage_ImportPackageStatus");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ImportPackage)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportPackage_ImportPackageType");
            });

            modelBuilder.Entity<ImportPackageStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImportPackageType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IndividualAchievementsCategory>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("PK__Individu__CBD747063607E224");

                entity.HasComment("Индивидуальные достижения, учитываемые образовательной организацией");

                entity.Property(e => e.IdCategory).HasComment("ИД категории инд. достижения");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("Наименование категории инд. достижения");
            });

            modelBuilder.Entity<IndividualAchivement>(entity =>
            {
                entity.HasKey(e => e.Iaid);

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("IX_IndividualAchivement_AppID");

                entity.HasIndex(e => e.EntrantDocumentId)
                    .HasName("IX_IndividualAchivement_EntrandDocumentID");

                entity.Property(e => e.Iaid).HasColumnName("IAID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.Iamark)
                    .HasColumnName("IAMark")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Ianame)
                    .HasColumnName("IAName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Iauid)
                    .HasColumnName("IAUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.IndividualAchivement)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IndividualAchivement_Application1");

                entity.HasOne(d => d.EntrantDocument)
                    .WithMany(p => p.IndividualAchivement)
                    .HasForeignKey(d => d.EntrantDocumentId)
                    .HasConstraintName("FK_IndividualAchivement_EntrantDocument1");

                entity.HasOne(d => d.IdAchievementNavigation)
                    .WithMany(p => p.IndividualAchivement)
                    .HasForeignKey(d => d.IdAchievement)
                    .HasConstraintName("FK_IndividualAchivement_InstitutionAchievements");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.HasIndex(e => e.FullName);

                entity.HasIndex(e => e.RegionId)
                    .HasName("IX_Institution_Region");

                entity.HasIndex(e => new { e.BriefName, e.InstitutionId })
                    .HasName("_dta_index_Institution_12_1321771766__K1_4");

                entity.HasIndex(e => new { e.MainEsrpOrgId, e.EsrpOrgId })
                    .HasName("_dta_index_Institution_12_1321771766__K25_K21");

                entity.HasIndex(e => new { e.InstitutionId, e.InstitutionTypeId, e.FullName, e.BriefName, e.FormOfLawId, e.RegionId, e.FounderEsrpOrgId, e.CreatedDate, e.ModifiedDate, e.OwnerDepartment, e.MainEsrpOrgId, e.Site, e.Address, e.Phone, e.Fax, e.HasMilitaryDepartment, e.HasHostel, e.HostelCapacity, e.HasHostelForEntrants, e.HostelAttachmentId, e.Inn, e.Ogrn, e.AdmissionStructurePublishDate, e.ReceivingApplicationDate, e.DateUpdated, e.EsrpOrgId })
                    .HasName("_dta_index_Institution_12_1321771766__K21_1_2_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_22_23_24_25_26");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AdmissionStructurePublishDate).HasColumnType("datetime");

                entity.Property(e => e.BriefName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EsrpOrgId).HasColumnName("EsrpOrgID");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormOfLawId).HasColumnName("FormOfLawID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HostelAttachmentId).HasColumnName("HostelAttachmentID");

                entity.Property(e => e.Inn)
                    .HasColumnName("INN")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstitutionTypeId)
                    .HasColumnName("InstitutionTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Ogrn)
                    .IsRequired()
                    .HasColumnName("OGRN")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OwnerDepartment)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivingApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Site)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.FormOfLaw)
                    .WithMany(p => p.Institution)
                    .HasForeignKey(d => d.FormOfLawId)
                    .HasConstraintName("FK_Institution_FormOfLaw");

                entity.HasOne(d => d.HostelAttachment)
                    .WithMany(p => p.Institution)
                    .HasForeignKey(d => d.HostelAttachmentId)
                    .HasConstraintName("FK_Institution_Attachment");

                entity.HasOne(d => d.InstitutionType)
                    .WithMany(p => p.Institution)
                    .HasForeignKey(d => d.InstitutionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Institution_InstitutionType");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Institution)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Institution_RegionType");
            });

            modelBuilder.Entity<InstitutionAccreditation>(entity =>
            {
                entity.HasKey(e => e.AccreditationId);

                entity.Property(e => e.AccreditationId).HasColumnName("AccreditationID");

                entity.Property(e => e.Accreditation)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.InstitutionAccreditation)
                    .HasForeignKey(d => d.AttachmentId)
                    .HasConstraintName("FK_InstitutionAccreditation_Attachment");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.InstitutionAccreditation)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_InstitutionAccreditation_Institution");
            });

            modelBuilder.Entity<InstitutionAchievements>(entity =>
            {
                entity.HasKey(e => e.IdAchievement)
                    .HasName("PK__Institut__B09E6C0339D87308");

                entity.HasComment("Таблица “Индивидуальные достижения, учитываемые образовательной организацией");

                entity.Property(e => e.IdAchievement).HasComment("ИД достижения, учитываемого ОО");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("CampaignID")
                    .HasComment("Ссылка на ПК ОО FK (Campaign – Campaign¬ID) ");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCategory).HasComment("Ссылка на IndividualAchievementsCategory FK (IndividualAchievementsCategory – IdCategory) ");

                entity.Property(e => e.MaxValue)
                    .HasColumnType("decimal(7, 4)")
                    .HasComment("Макс балл за достижение");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("Наименование инд. достижения");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("Идентификатор достижения, указанный ОО");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.InstitutionAchievements)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK_InstitutionAchievements_Campaign");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.InstitutionAchievements)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitutionAchievements_IndividualAchievementsCategory");
            });

            modelBuilder.Entity<InstitutionDocumentType>(entity =>
            {
                entity.Property(e => e.InstitutionDocumentTypeId).HasColumnName("InstitutionDocumentTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InstitutionHistory>(entity =>
            {
                entity.HasIndex(e => e.AccreditationAttachmentId)
                    .HasName("IX_InstitutionHistory_AccreditationAttachment");

                entity.HasIndex(e => e.HostelAttachmentId)
                    .HasName("IX_InstitutionHistory_HostelAttachment");

                entity.HasIndex(e => e.InstitutionHistoryId)
                    .HasName("IX_InstitutionHistory_LicenseAttachment");

                entity.Property(e => e.InstitutionHistoryId).HasColumnName("InstitutionHistoryID");

                entity.Property(e => e.Accreditation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AccreditationAttachmentId).HasColumnName("AccreditationAttachmentID");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AdmissionStructurePublishDate).HasColumnType("datetime");

                entity.Property(e => e.BriefName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EsrpOrgId).HasColumnName("EsrpOrgID");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormOfLawId).HasColumnName("FormOfLawID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HostelAttachmentId).HasColumnName("HostelAttachmentID");

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasColumnName("INN")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.InstitutionTypeId).HasColumnName("InstitutionTypeID");

                entity.Property(e => e.LicenseAttachmentId).HasColumnName("LicenseAttachmentID");

                entity.Property(e => e.LicenseDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ogrn)
                    .IsRequired()
                    .HasColumnName("OGRN")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OwnerDepartment)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivingApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Site)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccreditationAttachment)
                    .WithMany(p => p.InstitutionHistoryAccreditationAttachment)
                    .HasForeignKey(d => d.AccreditationAttachmentId)
                    .HasConstraintName("FK_InstitutionHistory_AccreditationAttachment");

                entity.HasOne(d => d.FormOfLaw)
                    .WithMany(p => p.InstitutionHistory)
                    .HasForeignKey(d => d.FormOfLawId)
                    .HasConstraintName("FK_InstitutionHistory_FormOfLaw");

                entity.HasOne(d => d.HostelAttachment)
                    .WithMany(p => p.InstitutionHistoryHostelAttachment)
                    .HasForeignKey(d => d.HostelAttachmentId)
                    .HasConstraintName("FK_InstitutionHistory_HostelAttachment");

                entity.HasOne(d => d.InstitutionType)
                    .WithMany(p => p.InstitutionHistory)
                    .HasForeignKey(d => d.InstitutionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitutionHistory_InstitutionType");

                entity.HasOne(d => d.LicenseAttachment)
                    .WithMany(p => p.InstitutionHistoryLicenseAttachment)
                    .HasForeignKey(d => d.LicenseAttachmentId)
                    .HasConstraintName("FK_InstitutionHistory_LicenseAttachment");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.InstitutionHistory)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_InstitutionHistory_RegionType");
            });

            modelBuilder.Entity<InstitutionItem>(entity =>
            {
                entity.HasIndex(e => e.InstitutionId);

                entity.HasIndex(e => e.ParentId);

                entity.HasIndex(e => new { e.Name, e.ParentId, e.InstitutionId })
                    .HasName("UK_InstitutionItem_Name")
                    .IsUnique();

                entity.Property(e => e.InstitutionItemId).HasColumnName("InstitutionItemID");

                entity.Property(e => e.BriefName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Site)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.InstitutionItem)
                    .HasForeignKey(d => d.DirectionId)
                    .HasConstraintName("FK_InstitutionItem_Direction");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.InstitutionItem)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitutionItem_Institution");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.InstitutionItem)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitutionItem_InstitutionItemType");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_InstitutionItem_ParentInstitutionItem");
            });

            modelBuilder.Entity<InstitutionItemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.HasIndex(e => e.Name)
                    .HasName("UK_InstitutionItemType_Name")
                    .IsUnique();

                entity.Property(e => e.ItemTypeId)
                    .HasColumnName("ItemTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InstitutionLicense>(entity =>
            {
                entity.HasKey(e => e.LicenseId);

                entity.Property(e => e.LicenseId).HasColumnName("LicenseID");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.LicenseDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.InstitutionLicense)
                    .HasForeignKey(d => d.AttachmentId)
                    .HasConstraintName("FK_InstitutionLicense_Attachment");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.InstitutionLicense)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_InstitutionLicense_Institution");
            });

            modelBuilder.Entity<InstitutionStructure>(entity =>
            {
                entity.HasKey(e => e.InstitutionStructureId)
                    .IsClustered(false);

                entity.HasIndex(e => e.InstitutionItemId)
                    .HasName("UK_InstitutionStructure_Item")
                    .IsUnique();

                entity.HasIndex(e => e.Lineage)
                    .HasName("UK_InstitutionStructure_Lineage")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.ParentId);

                entity.Property(e => e.InstitutionStructureId).HasColumnName("InstitutionStructureID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Depth).HasDefaultValueSql("((1))");

                entity.Property(e => e.InstitutionItemId).HasColumnName("InstitutionItemID");

                entity.Property(e => e.Lineage)
                    .IsRequired()
                    .HasMaxLength(76)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(('/'+CONVERT([varchar](36),newid(),(0)))+'/')");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.InstitutionItem)
                    .WithOne(p => p.InstitutionStructure)
                    .HasForeignKey<InstitutionStructure>(d => d.InstitutionItemId)
                    .HasConstraintName("FK_InstitutionStructure_InstitutionItem");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_InstitutionStructure_InstitutionStructure");
            });

            modelBuilder.Entity<InstitutionType>(entity =>
            {
                entity.HasIndex(e => e.BriefName)
                    .HasName("UK_InstitutionType_BriefName")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("UK_InstitutionType_Name")
                    .IsUnique();

                entity.Property(e => e.InstitutionTypeId)
                    .HasColumnName("InstitutionTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BriefName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LevelBudget>(entity =>
            {
                entity.HasKey(e => e.IdLevelBudget);

                entity.Property(e => e.IdLevelBudget).ValueGeneratedNever();

                entity.Property(e => e.BudgetName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MapAdmissionData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map_AdmissionData");
            });

            modelBuilder.Entity<MapAdmissionVolume>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map_AdmissionVolume");

                entity.Property(e => e.NewUid)
                    .HasColumnName("NewUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OldUid)
                    .HasColumnName("OldUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MapApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map_Application");
            });

            modelBuilder.Entity<MapApplicationSelectedCompetitiveGroupItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map_ApplicationSelectedCompetitiveGroupItem");
            });

            modelBuilder.Entity<MapCompetitiveGroupItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map_CompetitiveGroupItem");

                entity.Property(e => e.NewUid)
                    .HasColumnName("NewUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OldUid)
                    .HasColumnName("OldUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MapCompetitiveGroupTargetItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map_CompetitiveGroupTargetItem");

                entity.Property(e => e.NewUid)
                    .HasColumnName("NewUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OldUid)
                    .HasColumnName("OldUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MapDirections>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map_Directions");

                entity.Property(e => e.NewUid)
                    .HasColumnName("NewUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OldUid)
                    .HasColumnName("OldUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MapEntranceTestProfileDirection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map_EntranceTestProfileDirection");
            });

            modelBuilder.Entity<MapInstitutionItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map_InstitutionItem");

                entity.Property(e => e.NewUid)
                    .HasColumnName("NewUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OldUid)
                    .HasColumnName("OldUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MapInstitutionStructure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map_InstitutionStructure");

                entity.Property(e => e.NewUid)
                    .HasColumnName("NewUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OldUid)
                    .HasColumnName("OldUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Migrations>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ScriptDate).HasColumnType("datetime");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NationalityType>(entity =>
            {
                entity.HasKey(e => e.NationalityId);

                entity.Property(e => e.NationalityId)
                    .HasColumnName("NationalityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NormativeDictionary>(entity =>
            {
                entity.HasKey(e => e.DictionaryId);

                entity.HasIndex(e => e.Name)
                    .HasName("UK_NormativeDictionary_Name")
                    .IsUnique();

                entity.Property(e => e.DictionaryId)
                    .HasColumnName("DictionaryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionStateId).HasColumnName("VersionStateID");

                entity.HasOne(d => d.VersionState)
                    .WithMany(p => p.NormativeDictionary)
                    .HasForeignKey(d => d.VersionStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NormativeDictionary_NormativeVersionState");
            });

            modelBuilder.Entity<NormativeVersionState>(entity =>
            {
                entity.HasKey(e => e.VersionStateId);

                entity.Property(e => e.VersionStateId).HasColumnName("VersionStateID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OlympicDiplomType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_OlympicDiplomType_Name")
                    .IsUnique();

                entity.Property(e => e.OlympicDiplomTypeId).HasColumnName("OlympicDiplomTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OlympicLevel>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_OlympicLevel_Name")
                    .IsUnique();

                entity.Property(e => e.OlympicLevelId).HasColumnName("OlympicLevelID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OlympicType>(entity =>
            {
                entity.HasKey(e => e.OlympicId);

                entity.Property(e => e.OlympicId).HasColumnName("OlympicID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.OlympicLevelId).HasColumnName("OlympicLevelID");

                entity.Property(e => e.OrganizerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.HasOne(d => d.OlympicLevel)
                    .WithMany(p => p.OlympicType)
                    .HasForeignKey(d => d.OlympicLevelId)
                    .HasConstraintName("FK_OlympicType_OlympicLevel");
            });

            modelBuilder.Entity<OlympicTypeSubjectLink>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OlympicId).HasColumnName("OlympicID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.SubjectLevelId).HasColumnName("SubjectLevelID");

                entity.HasOne(d => d.Olympic)
                    .WithMany(p => p.OlympicTypeSubjectLink)
                    .HasForeignKey(d => d.OlympicId)
                    .HasConstraintName("FK_OlympicTypeSubjectLink_OlympicType");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.OlympicTypeSubjectLink)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OlympicTypeSubjectLink_Subject");

                entity.HasOne(d => d.SubjectLevel)
                    .WithMany(p => p.OlympicTypeSubjectLink)
                    .HasForeignKey(d => d.SubjectLevelId)
                    .HasConstraintName("FK_OlympicLevel_OlympicTypeSubjectLink");
            });

            modelBuilder.Entity<OrderOfAdmission>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.HasIndex(e => new { e.OrderId, e.OrderStatus, e.DateCreated, e.DateEdited, e.DatePublished, e.Uid, e.CampaignId, e.Course, e.EducationLevelId, e.EducationFormId, e.EducationSourceId, e.Stage, e.IsForBeneficiary, e.InstitutionId })
                    .HasName("_dta_index_OrderOfAdmission_12_1432392172__K6_1_2_3_4_5_7_8_9_10_11_12_13_14");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateEdited).HasColumnType("datetime");

                entity.Property(e => e.DatePublished).HasColumnType("datetime");

                entity.Property(e => e.EducationFormId).HasColumnName("EducationFormID");

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.EducationSourceId).HasColumnName("EducationSourceID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.OrderOfAdmission)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK_OrderOfAdmission_Campaign");

                entity.HasOne(d => d.EducationForm)
                    .WithMany(p => p.OrderOfAdmissionEducationForm)
                    .HasForeignKey(d => d.EducationFormId)
                    .HasConstraintName("FK_OrderOfAdmission_AdmissionItemTypeForm");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.OrderOfAdmissionEducationLevel)
                    .HasForeignKey(d => d.EducationLevelId)
                    .HasConstraintName("FK_OrderOfAdmission_AdmissionItemTypeLevel");

                entity.HasOne(d => d.EducationSource)
                    .WithMany(p => p.OrderOfAdmissionEducationSource)
                    .HasForeignKey(d => d.EducationSourceId)
                    .HasConstraintName("FK_OrderOfAdmission_AdmissionItemTypeSource");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.OrderOfAdmission)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderOfAdmission_Institution");
            });

            modelBuilder.Entity<OrderOfAdmissionHistory>(entity =>
            {
                entity.HasIndex(e => e.ModifiedDate)
                    .HasName("IX_OrderOfAmissionHistory_ModifiedDate");

                entity.HasIndex(e => new { e.CreatedDate, e.ModifiedDate, e.ApplicationId, e.DatePublished, e.Id, e.OrderId })
                    .HasName("IX_OrderOfAmissionHistory_OrderID");

                entity.HasIndex(e => new { e.ModifiedDate, e.DatePublished, e.CreatedDate, e.Id, e.OrderId, e.ApplicationId })
                    .HasName("IX_OrderOfAmissionHistory_ApplicationID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DatePublished).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.OrderOfAdmissionHistory)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderOfAdmissionHistory_Application");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderOfAdmissionHistory)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderOfAdmissionHistory_OrderOfAdmission");
            });

            modelBuilder.Entity<OrderOfAdmissionType>(entity =>
            {
                entity.HasKey(e => e.OrderTypeId);

                entity.Property(e => e.OrderTypeId)
                    .HasColumnName("OrderTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParentDirection>(entity =>
            {
                entity.HasKey(e => e.ParentDirectionId)
                    .IsClustered(false);

                entity.HasIndex(e => e.Code)
                    .HasName("UK_ParentDirection_Code")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ParentDirectionId).HasColumnName("ParentDirectionID");

                entity.Property(e => e.Code)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParentDirectionOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ParentDirection_old");

                entity.Property(e => e.Code)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ParentDirectionId).HasColumnName("ParentDirectionID");
            });

            modelBuilder.Entity<PersonalDataAccessLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.AccessMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NewData).HasColumnType("text");

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldData).HasColumnType("text");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreparatoryCourse>(entity =>
            {
                entity.HasIndex(e => new { e.InstitutionId, e.CourseName })
                    .HasName("UK_PreparatoryCourse")
                    .IsUnique();

                entity.Property(e => e.PreparatoryCourseId).HasColumnName("PreparatoryCourseID");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CourseTypeId).HasColumnName("CourseTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Information).IsUnicode(false);

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.PreparatoryCourse)
                    .HasForeignKey(d => d.CourseTypeId)
                    .HasConstraintName("FK_PreparatoryCourse_CourseType");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.PreparatoryCourse)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_PreparatoryCourse_Institution");

                entity.HasOne(d => d.MoreInformationNavigation)
                    .WithMany(p => p.PreparatoryCourse)
                    .HasForeignKey(d => d.MoreInformation)
                    .HasConstraintName("FK_PreparatoryCourse_Attachment");
            });

            modelBuilder.Entity<RecomendedLists>(entity =>
            {
                entity.HasKey(e => e.RecListId);

                entity.HasIndex(e => e.CampaignId);

                entity.HasIndex(e => e.CompetitiveGroupId);

                entity.HasIndex(e => e.DirectionId);

                entity.HasIndex(e => e.InstitutionId);

                entity.Property(e => e.RecListId).HasColumnName("RecListID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CompetitiveGroupId).HasColumnName("CompetitiveGroupID");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.EduFormId).HasColumnName("EduFormID");

                entity.Property(e => e.EduLevelId).HasColumnName("EduLevelID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.Rating).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.RecomendedLists)
                    .HasForeignKey(d => d.CampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecomendedLists_Campaign1");

                entity.HasOne(d => d.CompetitiveGroup)
                    .WithMany(p => p.RecomendedLists)
                    .HasForeignKey(d => d.CompetitiveGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecomendedLists_CompetitiveGroup1");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.RecomendedLists)
                    .HasForeignKey(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecomendedLists_Direction1");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.RecomendedLists)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecomendedLists_Institution1");
            });

            modelBuilder.Entity<RecomendedListsHistory>(entity =>
            {
                entity.HasIndex(e => e.RecListId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateAdd).HasColumnType("datetime");

                entity.Property(e => e.DateDelete).HasColumnType("datetime");

                entity.Property(e => e.RecListId).HasColumnName("RecListID");

                entity.HasOne(d => d.RecList)
                    .WithMany(p => p.RecomendedListsHistory)
                    .HasForeignKey(d => d.RecListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecomendedListsHistory_RecomendedLists1");
            });

            modelBuilder.Entity<RegionType>(entity =>
            {
                entity.HasKey(e => e.RegionId);

                entity.HasIndex(e => new { e.OkatoCode, e.OkatoModified })
                    .HasName("IX_RegionType_Okato");

                entity.HasIndex(e => new { e.DisplayOrder, e.CountryId, e.Name })
                    .HasName("UX_RegionType")
                    .IsUnique();

                entity.Property(e => e.RegionId).ValueGeneratedNever();

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.EsrpCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OkatoCode)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OkatoModified).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.RegionType)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegionType_CountryType");
            });

            modelBuilder.Entity<RequestComments>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.Property(e => e.CommentId)
                    .HasColumnName("Comment ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.Commentor)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.HasOne(d => d.RequestDirection)
                    .WithMany(p => p.RequestComments)
                    .HasForeignKey(d => new { d.DirectionId, d.InstitutionId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestComments_RequestDirection");
            });

            modelBuilder.Entity<RequestDirection>(entity =>
            {
                entity.HasKey(e => new { e.DirectionId, e.RequestId });

                entity.Property(e => e.DirectionId).HasColumnName("Direction ID");

                entity.Property(e => e.RequestId).HasColumnName("Request ID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestDirection)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestDirection_Request");
            });

            modelBuilder.Entity<RvidocumentTypes>(entity =>
            {
                entity.HasKey(e => e.DocumentTypeCode);

                entity.ToTable("RVIDocumentTypes");

                entity.Property(e => e.DocumentTypeCode).ValueGeneratedNever();

                entity.Property(e => e.DocumentTypeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RvipersonIdentDocs>(entity =>
            {
                entity.HasKey(e => e.PersonIdentDocId);

                entity.ToTable("RVIPersonIdentDocs");

                entity.HasIndex(e => new { e.DocumentSeries, e.DocumentNumber, e.DocumentTypeCode, e.PersonId })
                    .HasName("IY_RVIPersonIdentDocs_PersonId");

                entity.HasIndex(e => new { e.PersonId, e.DocumentNumber, e.DocumentSeries, e.DocumentTypeCode })
                    .HasName("IY_RVIPersonIdentDocs_DocumentSeriesNumberType");

                entity.Property(e => e.PersonIdentDocId)
                    .HasColumnName("PersonIdentDocID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentOrganization)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentSeries)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.DocumentTypeCodeNavigation)
                    .WithMany(p => p.RvipersonIdentDocs)
                    .HasForeignKey(d => d.DocumentTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RVIPersonIdentDocs_RVIDocumentTypes");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.RvipersonIdentDocs)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RVIPersonIdentDocs_RVIPersons");
            });

            modelBuilder.Entity<Rvipersons>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.ToTable("RVIPersons");

                entity.HasIndex(e => new { e.IsRecordDeleted, e.NormSurname, e.NormName, e.NormSecondName })
                    .HasName("IY_RVIPersons_NormFullName");

                entity.Property(e => e.PersonId).ValueGeneratedNever();

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Inn)
                    .HasColumnName("INN")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IntegralUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NormName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NormSecondName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NormSurname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Snils)
                    .HasColumnName("SNILS")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UK_Subject_Name")
                    .IsUnique();

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubjectEgeMinValue>(entity =>
            {
                entity.HasKey(e => e.ScoreId);

                entity.HasIndex(e => e.SubjectId)
                    .HasName("UK_SubjectEgeMinValue_SubjectID")
                    .IsUnique();

                entity.Property(e => e.ScoreId).HasColumnName("ScoreID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithOne(p => p.SubjectEgeMinValue)
                    .HasForeignKey<SubjectEgeMinValue>(d => d.SubjectId)
                    .HasConstraintName("FK_SubjectEgeMinValue_Subject");
            });

            modelBuilder.Entity<SubjectEgeMinValueCopy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SubjectEgeMinValue_copy");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ScoreId).HasColumnName("ScoreID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<TmpEgeMarksStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_EgeMarksStat");

                entity.Property(e => e.AppId).HasColumnName("AppID");

                entity.Property(e => e.CompGroupId).HasColumnName("CompGroupID");

                entity.Property(e => e.DirName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DirNewCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocSer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EduFinansSourceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EduFormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EduLevelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntrId).HasColumnName("EntrID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameParent)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InstId).HasColumnName("InstID");

                entity.Property(e => e.IsPrivate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OlimpId).HasColumnName("OlimpID");

                entity.Property(e => e.OlimpName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OlimpOrganizerName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.RegionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UchrName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TranslationRvidtIdentityDt>(entity =>
            {
                entity.ToTable("Translation_RVIDT_IdentityDT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdentityDocumentTypeId).HasColumnName("IdentityDocumentTypeID");

                entity.HasOne(d => d.DocumentTypeCodeNavigation)
                    .WithMany(p => p.TranslationRvidtIdentityDt)
                    .HasForeignKey(d => d.DocumentTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Translation_RVIDT_IdentityDT_RVIDocumentTypes");

                entity.HasOne(d => d.IdentityDocumentType)
                    .WithMany(p => p.TranslationRvidtIdentityDt)
                    .HasForeignKey(d => d.IdentityDocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Translation_RVIDT_IdentityDT_IdentityDocumentType");
            });

            modelBuilder.Entity<UserPolicy>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => new { e.Position, e.PhoneNumber, e.Comment, e.AvailableEgeCheckCount, e.PinCode, e.DateUpdated, e.IsReadOnly, e.UserId, e.InstitutionId, e.IsMainAdmin, e.FullName, e.UserName })
                    .HasName("_dta_index_UserPolicy_12_139863565__K5_1_2_3_4_6_7_8_9_10_11_12");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.UserPolicy)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_UserPolicy_Institution");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserPolicy)
                    .HasForeignKey<UserPolicy>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPolicy_aspnet_Users");
            });

            modelBuilder.Entity<VCompetitiveGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCompetitiveGroup");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CompetitiveGroupId).HasColumnName("CompetitiveGroupID");

                entity.Property(e => e.DirectionId).HasColumnName("DirectionID");

                entity.Property(e => e.DirectionName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevelID");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumberBudgetOz).HasColumnName("NumberBudgetOZ");

                entity.Property(e => e.NumberPaidOz).HasColumnName("NumberPaidOZ");

                entity.Property(e => e.NumberTargetOz).HasColumnName("NumberTargetOZ");
            });

            modelBuilder.Entity<VEntrantDocuments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEntrantDocuments");

                entity.Property(e => e.EntrantDocumentId).HasColumnName("EntrantDocumentID");

                entity.Property(e => e.EntrantId).HasColumnName("EntrantID");
            });

            modelBuilder.Entity<ViolationType>(entity =>
            {
                entity.HasKey(e => e.ViolationId);

                entity.Property(e => e.ViolationId)
                    .HasColumnName("ViolationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BriefName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAspnetApplications>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfiles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePaths>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
