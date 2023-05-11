using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class HMOContext : DbContext
{
    public HMOContext()
    {
    }

    public HMOContext(DbContextOptions<HMOContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adress> Adresses { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<DateVaccine> DateVaccines { get; set; }

    public virtual DbSet<MembersDetail> MembersDetails { get; set; }

    public virtual DbSet<SickDate> SickDates { get; set; }

    public virtual DbSet<Street> Streets { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\CovidHMO\\DBFile\\HMOCorona.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adress>(entity =>
        {
            entity.HasKey(e => e.AdressKey).HasName("PK__Adress__0D93BC5468FB3B49");

            entity.ToTable("Adress");

            entity.Property(e => e.AdressKey)
                .ValueGeneratedNever()
                .HasColumnName("adress_key");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.HouseNum).HasColumnName("house_num");
            entity.Property(e => e.Street).HasColumnName("street");

            entity.HasOne(d => d.CityNavigation).WithMany(p => p.Adresses)
                .HasForeignKey(d => d.City)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Adress_ToTable");

            entity.HasOne(d => d.StreetNavigation).WithMany(p => p.Adresses)
                .HasForeignKey(d => d.Street)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Adress_ToStreet");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityKey).HasName("PK__Cities__097864371D6E5126");

            entity.Property(e => e.CityKey)
                .ValueGeneratedNever()
                .HasColumnName("city_key");
            entity.Property(e => e.City1)
                .HasMaxLength(50)
                .HasColumnName("city");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyKey).HasName("PK__Companie__A2528AFF74D00D82");

            entity.Property(e => e.CompanyKey)
                .ValueGeneratedNever()
                .HasColumnName("company_key");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .HasColumnName("company_name");
        });

        modelBuilder.Entity<DateVaccine>(entity =>
        {
            entity.HasKey(e => e.VaccinesKey).HasName("PK__Date_Vac__31C877AADDF1CEAF");

            entity.ToTable("Date_Vaccines");

            entity.Property(e => e.VaccinesKey)
                .ValueGeneratedNever()
                .HasColumnName("vaccines_key");
            entity.Property(e => e.Company).HasColumnName("company");
            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.VaccinesDate)
                .HasColumnType("date")
                .HasColumnName("vaccines_date");

            entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.DateVaccines)
                .HasForeignKey(d => d.Company)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Date_Vaccines_ToCompanies");

            entity.HasOne(d => d.Person).WithMany(p => p.DateVaccines)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Date_Vaccines_ToMemberDetails");
        });

        modelBuilder.Entity<MembersDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Members___3213E83F6740DD4F");

            entity.ToTable("Members_Details");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.BirthDate)
                .HasColumnType("date")
                .HasColumnName("birth_date");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("mobile_phone");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("phone");

            entity.HasOne(d => d.AddressNavigation).WithMany(p => p.MembersDetails)
                .HasForeignKey(d => d.Address)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Members_Details_ToTable");
        });

        modelBuilder.Entity<SickDate>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Sick_Dat__543848DFC0FE8F30");

            entity.ToTable("Sick_Date");

            entity.Property(e => e.PersonId)
                .ValueGeneratedNever()
                .HasColumnName("person_id");
            entity.Property(e => e.RecoverDate)
                .HasColumnType("date")
                .HasColumnName("recover_date");
            entity.Property(e => e.SickDate1)
                .HasColumnType("date")
                .HasColumnName("sick_date");

            entity.HasOne(d => d.Person).WithOne(p => p.SickDate)
                .HasForeignKey<SickDate>(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sick_Date_ToMembers_Details");
        });

        modelBuilder.Entity<Street>(entity =>
        {
            entity.HasKey(e => e.StreetKey).HasName("PK__Street__A763794981436EF4");

            entity.ToTable("Street");

            entity.Property(e => e.StreetKey)
                .ValueGeneratedNever()
                .HasColumnName("street_key");
            entity.Property(e => e.NaneStreet)
                .HasMaxLength(50)
                .HasColumnName("nane_street");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
