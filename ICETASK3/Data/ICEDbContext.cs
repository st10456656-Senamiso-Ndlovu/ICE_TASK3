using System;
using System.Collections.Generic;
using ICETASK3.Models;
using Microsoft.EntityFrameworkCore;

namespace ICETASK3.Data;

public partial class ICEDbContext : DbContext
{
    public ICEDbContext()
    {
    }

    public ICEDbContext(DbContextOptions<ICEDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Student> Students { get; set; }

   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PK__Module__2B747787DB3E8042");

            entity.ToTable("Module");

            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.Code)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Qualification)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52A79D3885A61");

            entity.ToTable("Student");

            entity.HasIndex(e => e.Stnumber, "UQ__Student__CD954AA289BBE592").IsUnique();

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.FullName).IsUnicode(false);
            entity.Property(e => e.Stnumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STNumber");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
