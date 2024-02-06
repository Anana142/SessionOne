using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Chempionat.DataBaseFolder;

public partial class User04Context : DbContext
{
    public User04Context()
    {
    }

    public User04Context(DbContextOptions<User04Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Drug> Drugs { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Graphic> Graphics { get; set; }

    public virtual DbSet<Hospitalization> Hospitalizations { get; set; }

    public virtual DbSet<InsurancePolicy> InsurancePolicies { get; set; }

    public virtual DbSet<InsurancyCompany> InsurancyCompanies { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Office> Offices { get; set; }

    public virtual DbSet<Pacient> Pacients { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Servise> Servises { get; set; }

    public virtual DbSet<TreamentDiagnosticMeasureDrug> TreamentDiagnosticMeasureDrugs { get; set; }

    public virtual DbSet<TreatmentDaignosticMeasureServise> TreatmentDaignosticMeasureServises { get; set; }

    public virtual DbSet<TreatmentDiadnosticMeasure> TreatmentDiadnosticMeasures { get; set; }

    public virtual DbSet<TreatmentDiagnosticMeasureType> TreatmentDiagnosticMeasureTypes { get; set; }

    public virtual DbSet<WorkShedule> WorkShedules { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=192.168.200.35;user=user04;password=93499;database=user04;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Condition>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ConditionsName).HasMaxLength(250);
            entity.Property(e => e.Id).HasColumnName("ID");

            entity.HasOne(d => d.IdNavigation).WithMany()
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_Conditions_Hospitalizations");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepartmentName).HasMaxLength(150);
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DoctorsAddress).HasMaxLength(250);
            entity.Property(e => e.DoctorsBirthday).HasColumnType("date");
            entity.Property(e => e.DoctorsEmail).HasMaxLength(250);
            entity.Property(e => e.DoctorsName).HasMaxLength(250);
            entity.Property(e => e.DoctorsPasportData).HasMaxLength(250);
            entity.Property(e => e.DoctorsPatronymic).HasMaxLength(250);
            entity.Property(e => e.DoctorsPhoneNumber).HasMaxLength(250);
            entity.Property(e => e.DoctorsRoleId).HasColumnName("DoctorsRoleID");
            entity.Property(e => e.DoctorsSurName).HasMaxLength(250);
            entity.Property(e => e.DoctorsWorkSchedulesId).HasColumnName("DoctorsWorkSchedulesID");

            entity.HasOne(d => d.DoctorsRole).WithMany(p => p.Doctors)
                .HasForeignKey(d => d.DoctorsRoleId)
                .HasConstraintName("FK_Doctors_Roles");

            entity.HasOne(d => d.DoctorsWorkSchedules).WithMany(p => p.Doctors)
                .HasForeignKey(d => d.DoctorsWorkSchedulesId)
                .HasConstraintName("FK_Doctors_WorkShedules");
        });

        modelBuilder.Entity<Drug>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DrugsName).HasMaxLength(250);
            entity.Property(e => e.DrugsVolume).HasColumnType("text");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Gender");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GendersName).HasMaxLength(100);
        });

        modelBuilder.Entity<Graphic>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GraphicsData).HasColumnType("date");
            entity.Property(e => e.GraphicsDoctorId).HasColumnName("GraphicsDoctorID");
            entity.Property(e => e.GraphicsOffiseId).HasColumnName("GraphicsOffiseID");

            entity.HasOne(d => d.GraphicsDoctor).WithMany(p => p.Graphics)
                .HasForeignKey(d => d.GraphicsDoctorId)
                .HasConstraintName("FK_Graphics_Doctors");

            entity.HasOne(d => d.GraphicsOffise).WithMany(p => p.Graphics)
                .HasForeignKey(d => d.GraphicsOffiseId)
                .HasConstraintName("FK_Graphics_Offices");
        });

        modelBuilder.Entity<Hospitalization>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HospitalizationsAddInformations).HasColumnType("text");
            entity.Property(e => e.HospitalizationsConditionsId).HasColumnName("HospitalizationsConditionsID");
            entity.Property(e => e.HospitalizationsDate).HasColumnType("date");
            entity.Property(e => e.HospitalizationsDepartmentId).HasColumnName("HospitalizationsDepartmentID");
            entity.Property(e => e.HospitalizationsPacientId).HasColumnName("HospitalizationsPacientID");
            entity.Property(e => e.HospitalizationsTarget).HasColumnType("text");
            entity.Property(e => e.HospitalizationsTreatmentDiagnosticMeasuresId).HasColumnName("HospitalizationsTreatmentDiagnosticMeasuresID");
            entity.Property(e => e.HospitalizationwhyRefusal).HasColumnType("text");

            entity.HasOne(d => d.HospitalizationsDepartment).WithMany(p => p.Hospitalizations)
                .HasForeignKey(d => d.HospitalizationsDepartmentId)
                .HasConstraintName("FK_Hospitalizations_Departments");

            entity.HasOne(d => d.HospitalizationsPacient).WithMany(p => p.Hospitalizations)
                .HasForeignKey(d => d.HospitalizationsPacientId)
                .HasConstraintName("FK_Hospitalizations_Pacients");

            entity.HasOne(d => d.HospitalizationsTreatmentDiagnosticMeasures).WithMany(p => p.Hospitalizations)
                .HasForeignKey(d => d.HospitalizationsTreatmentDiagnosticMeasuresId)
                .HasConstraintName("FK_Hospitalizations_TreatmentDiadnosticMeasures");
        });

        modelBuilder.Entity<InsurancePolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_InsurancePolicy");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsurancePoliciesCompanyId).HasColumnName("InsurancePoliciesCompanyID");
            entity.Property(e => e.InsurancePoliciesStopDate).HasColumnType("date");

            entity.HasOne(d => d.InsurancePoliciesCompany).WithMany(p => p.InsurancePolicies)
                .HasForeignKey(d => d.InsurancePoliciesCompanyId)
                .HasConstraintName("FK_InsurancePolicy_InsurancyCompany");
        });

        modelBuilder.Entity<InsurancyCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_InsurancyCompany");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsurancyCompaniesTitle).HasMaxLength(100);
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WorkingSpace");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.JobsCompanyName).HasMaxLength(200);
        });

        modelBuilder.Entity<Office>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.OfficesName).HasMaxLength(50);
        });

        modelBuilder.Entity<Pacient>(entity =>
        {
            entity.HasKey(e => e.IdmedicalCard);

            entity.Property(e => e.IdmedicalCard).HasColumnName("IDMedicalCard");
            entity.Property(e => e.PacientCardIssueDate).HasColumnType("date");
            entity.Property(e => e.PacientsAddress).HasMaxLength(100);
            entity.Property(e => e.PacientsBirthday).HasColumnType("date");
            entity.Property(e => e.PacientsEmail).HasMaxLength(100);
            entity.Property(e => e.PacientsGenderId).HasColumnName("PacientsGenderID");
            entity.Property(e => e.PacientsInsurancePolicyId).HasColumnName("PacientsInsurancePolicyID");
            entity.Property(e => e.PacientsJobId).HasColumnName("PacientsJobID");
            entity.Property(e => e.PacientsName).HasMaxLength(100);
            entity.Property(e => e.PacientsPasportData)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PacientsPatronymic).HasMaxLength(100);
            entity.Property(e => e.PacientsPhoneNumber).HasMaxLength(17);
            entity.Property(e => e.PacientsPhoto).HasColumnType("image");
            entity.Property(e => e.PacientsSurName).HasMaxLength(100);

            entity.HasOne(d => d.PacientsGender).WithMany(p => p.Pacients)
                .HasForeignKey(d => d.PacientsGenderId)
                .HasConstraintName("FK_Pacients_Gender");

            entity.HasOne(d => d.PacientsInsurancePolicy).WithMany(p => p.Pacients)
                .HasForeignKey(d => d.PacientsInsurancePolicyId)
                .HasConstraintName("FK_Pacients_InsurancePolicy");

            entity.HasOne(d => d.PacientsJob).WithMany(p => p.Pacients)
                .HasForeignKey(d => d.PacientsJobId)
                .HasConstraintName("FK_Pacients_WorkingSpace");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RolesName).HasMaxLength(250);
        });

        modelBuilder.Entity<Servise>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ServisesCost).HasColumnType("money");
            entity.Property(e => e.ServisesName).HasMaxLength(250);
        });

        modelBuilder.Entity<TreamentDiagnosticMeasureDrug>(entity =>
        {
            entity.HasKey(e => new { e.TreamentDiagnosticMeasureId, e.DrugsId });

            entity.Property(e => e.TreamentDiagnosticMeasureId).HasColumnName("TreamentDiagnosticMeasureID");
            entity.Property(e => e.DrugsId).HasColumnName("DrugsID");

            entity.HasOne(d => d.Drugs).WithMany(p => p.TreamentDiagnosticMeasureDrugs)
                .HasForeignKey(d => d.DrugsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreamentDiagnosticMeasureDrugs_Drugs");

            entity.HasOne(d => d.TreamentDiagnosticMeasure).WithMany(p => p.TreamentDiagnosticMeasureDrugs)
                .HasForeignKey(d => d.TreamentDiagnosticMeasureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreamentDiagnosticMeasureDrugs_TreatmentDiadnosticMeasures");
        });

        modelBuilder.Entity<TreatmentDaignosticMeasureServise>(entity =>
        {
            entity.HasKey(e => new { e.TreatmentDaignosticMeasureId, e.ServisesId });

            entity.Property(e => e.TreatmentDaignosticMeasureId).HasColumnName("TreatmentDaignosticMeasureID");
            entity.Property(e => e.ServisesId).HasColumnName("ServisesID");

            entity.HasOne(d => d.Servises).WithMany(p => p.TreatmentDaignosticMeasureServises)
                .HasForeignKey(d => d.ServisesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreatmentDaignosticMeasureServises_Servises");

            entity.HasOne(d => d.TreatmentDaignosticMeasure).WithMany(p => p.TreatmentDaignosticMeasureServises)
                .HasForeignKey(d => d.TreatmentDaignosticMeasureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreatmentDaignosticMeasureServises_TreatmentDiadnosticMeasures");
        });

        modelBuilder.Entity<TreatmentDiadnosticMeasure>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TreatmentDiadnosticMeasuresDate).HasColumnType("date");
            entity.Property(e => e.TreatmentDiadnosticMeasuresDoctorId).HasColumnName("TreatmentDiadnosticMeasuresDoctorID");
            entity.Property(e => e.TreatmentDiadnosticMeasuresOfficeId).HasColumnName("TreatmentDiadnosticMeasuresOfficeID");
            entity.Property(e => e.TreatmentDiadnosticMeasuresPacientId).HasColumnName("TreatmentDiadnosticMeasuresPacientID");
            entity.Property(e => e.TreatmentDiadnosticMeasuresRecommendations).HasMaxLength(250);
            entity.Property(e => e.TreatmentDiadnosticMeasuresResult).HasMaxLength(250);
            entity.Property(e => e.TreatmentDiadnosticMeasuresTitle).HasMaxLength(250);
            entity.Property(e => e.TreatmentDiadnosticMeasuresTypeId).HasColumnName("TreatmentDiadnosticMeasuresTypeID");

            entity.HasOne(d => d.TreatmentDiadnosticMeasuresDoctor).WithMany(p => p.TreatmentDiadnosticMeasures)
                .HasForeignKey(d => d.TreatmentDiadnosticMeasuresDoctorId)
                .HasConstraintName("FK_TreatmentDiadnosticMeasures_Doctors");

            entity.HasOne(d => d.TreatmentDiadnosticMeasuresOffice).WithMany(p => p.TreatmentDiadnosticMeasures)
                .HasForeignKey(d => d.TreatmentDiadnosticMeasuresOfficeId)
                .HasConstraintName("FK_TreatmentDiadnosticMeasures_Offices");

            entity.HasOne(d => d.TreatmentDiadnosticMeasuresType).WithMany(p => p.TreatmentDiadnosticMeasures)
                .HasForeignKey(d => d.TreatmentDiadnosticMeasuresTypeId)
                .HasConstraintName("FK_TreatmentDiadnosticMeasures_TreatmentDiagnosticMeasureTypes");
        });

        modelBuilder.Entity<TreatmentDiagnosticMeasureType>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TreatmentDiagnosticMeasureTypesName).HasMaxLength(150);
        });

        modelBuilder.Entity<WorkShedule>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
