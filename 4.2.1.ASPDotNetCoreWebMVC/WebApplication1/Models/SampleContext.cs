using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class SampleContext : DbContext
{
    public SampleContext()
    {
    }

    public SampleContext(DbContextOptions<SampleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-P4JDU1G\\INSTANCE01;Database=Sample;Trusted_connection=True;User ID=sa;Password=mrbob;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("book");

            entity.Property(e => e.Author)
                .IsUnicode(false)
                .HasColumnName("author");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Publisher)
                .IsUnicode(false)
                .HasColumnName("publisher");
            entity.Property(e => e.Title)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Deptcd);

            entity.ToTable("dept");

            entity.Property(e => e.Deptcd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("deptcd");
            entity.Property(e => e.Deptnm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deptnm");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Empcd);

            entity.ToTable("emp");

            entity.Property(e => e.Empcd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empcd");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Birthday)
                .HasColumnType("datetime")
                .HasColumnName("birthday");
            entity.Property(e => e.Deptcd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("deptcd");
            entity.Property(e => e.Empnm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empnm");
            entity.Property(e => e.Kana)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("kana");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
