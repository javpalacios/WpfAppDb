using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfAppDb.Models;

public partial class CompanyDirectoryContext : DbContext
{
    public CompanyDirectoryContext() {}

    public CompanyDirectoryContext(DbContextOptions<CompanyDirectoryContext> options) : base(options) {}

    public virtual DbSet<Department> Departments { get; set; }
    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=company_directory;User Id=sa;Password=SQLserver_Adm1n;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.Position)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Department)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
