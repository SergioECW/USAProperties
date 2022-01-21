using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Data.Context
{
    public partial class USAPropertysContext : DbContext
    {
        public USAPropertysContext()
        {
        }

        public USAPropertysContext(DbContextOptions<USAPropertysContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Owner> Owners { get; set; } = null!;
        public virtual DbSet<Property> Properties { get; set; } = null!;
        public virtual DbSet<Propertyimage> Propertyimages { get; set; } = null!;
        public virtual DbSet<Propertytrace> Propertytraces { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NA8GVVS;Database=USAPropertys;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>(entity =>
            {
                entity.HasKey(e => e.Idowner)
                    .HasName("PK__OWNER___BC3249F63A0E638E");

                entity.ToTable("OWNER_");

                entity.Property(e => e.Idowner).HasColumnName("IDOWNER");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Birthday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BIRTHDAY");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Photo)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("PHOTO");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasKey(e => e.Idproperty)
                    .HasName("PK__PROPERTY__B92DE70DF398C56E");

                entity.ToTable("PROPERTY");

                entity.Property(e => e.Idproperty).HasColumnName("IDPROPERTY");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Codeinternal).HasColumnName("CODEINTERNAL");

                entity.Property(e => e.Idowner).HasColumnName("IDOWNER");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Year).HasColumnName("YEAR");

                entity.HasOne(d => d.IdownerNavigation)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.Idowner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROPERTY_OWNER_");
            });

            modelBuilder.Entity<Propertyimage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROPERTYIMAGE");

                entity.HasIndex(e => e.Idpropertyimage, "UQ__PROPERTY__161B9CC7DF81EF39")
                    .IsUnique();

                entity.Property(e => e.Enabled)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED")
                    .IsFixedLength();

                entity.Property(e => e.Files).HasColumnName("FILES");

                entity.Property(e => e.Idproperty).HasColumnName("IDPROPERTY");

                entity.Property(e => e.Idpropertyimage).HasColumnName("IDPROPERTYIMAGE");

                entity.HasOne(d => d.IdpropertyNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idproperty)
                    .HasConstraintName("FK_PROPERTYIMAGE_PROPERTY");
            });

            modelBuilder.Entity<Propertytrace>(entity =>
            {
                entity.HasKey(e => e.Idpropertytrace)
                    .HasName("PK__PROPERTY__634310EC9075FBDF");

                entity.ToTable("PROPERTYTRACE");

                entity.Property(e => e.Idpropertytrace).HasColumnName("IDPROPERTYTRACE");

                entity.Property(e => e.Datesale)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DATESALE");

                entity.Property(e => e.Idproperty).HasColumnName("IDPROPERTY");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Tax)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TAX");

                entity.Property(e => e.Value)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("VALUE");

                entity.HasOne(d => d.IdpropertyNavigation)
                    .WithMany(p => p.Propertytraces)
                    .HasForeignKey(d => d.Idproperty)
                    .HasConstraintName("FK_PROPERTYTRACE_PROPERTY");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
