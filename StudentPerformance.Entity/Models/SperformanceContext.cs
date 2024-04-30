using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentPerformance.Entity.Models;

public partial class SperformanceContext : DbContext
{
    public SperformanceContext()
    {
    }

    public SperformanceContext(DbContextOptions<SperformanceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Marksheet> Marksheets { get; set; }

    public virtual DbSet<StudentMaster> StudentMasters { get; set; }
    //public object Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-OOS7IVTU\\MANASSQLSERVER;Initial Catalog=SPerformance;User Id=sa; password=root;Persist Security Info=False;Integrated Security=false;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Marksheet>(entity =>
        {
            entity.ToTable("Marksheet");

            entity.Property(e => e.MarkSheetId).ValueGeneratedNever();
            entity.Property(e => e.Subject).HasMaxLength(50);

            entity.HasOne(d => d.Student).WithMany(p => p.Marksheets)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_Marksheet_Marksheet");
        });

        modelBuilder.Entity<StudentMaster>(entity =>
        {
            entity.HasKey(e => e.StudentId);

            entity.ToTable("StudentMaster");

            entity.Property(e => e.StudentId).ValueGeneratedNever();
            entity.Property(e => e.StudentName).HasMaxLength(150);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
