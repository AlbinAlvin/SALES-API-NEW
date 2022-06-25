using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sales.Models
{
    public partial class Mobi_SalesContext : DbContext
    {
        public Mobi_SalesContext()
        {
        }

        public Mobi_SalesContext(DbContextOptions<Mobi_SalesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MobiBranch> MobiBranches { get; set; } = null!;
        public virtual DbSet<MobiCatagory> MobiCatagories { get; set; } = null!;
        public virtual DbSet<MobiCountry> MobiCountries { get; set; } = null!;
        public virtual DbSet<MobiDistrict> MobiDistricts { get; set; } = null!;
        public virtual DbSet<MobiPurchase> MobiPurchases { get; set; } = null!;
        public virtual DbSet<MobiPurchaseProductStock> MobiPurchaseProductStocks { get; set; } = null!;
        public virtual DbSet<MobiState> MobiStates { get; set; } = null!;
        public virtual DbSet<MobiStatus> MobiStatuses { get; set; } = null!;
        public virtual DbSet<MobiSubCatagory> MobiSubCatagories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-F5K3EA3;Database=Mobi_Sales;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MobiBranch>(entity =>
            {
                entity.ToTable("MOBI_BRANCH");

                entity.Property(e => e.Banner).IsUnicode(false);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.District)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Icon).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MobiBranches)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BRANCH_MOBI_STATUS_Id");
            });

            modelBuilder.Entity<MobiCatagory>(entity =>
            {
                entity.ToTable("MOBI_CATAGORY");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MobiCatagories)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_STATUS_Id");
            });

            modelBuilder.Entity<MobiCountry>(entity =>
            {
                entity.ToTable("MOBI_COUNTRY");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MobiCountries)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_COUNTRY_STATUS_Id");
            });

            modelBuilder.Entity<MobiDistrict>(entity =>
            {
                entity.ToTable("MOBI_DISTRICT");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MobiDistricts)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_DISTRICT_COUNTRY_Id");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.MobiDistricts)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_DISTRICT_STATUS_Id");
            });

            modelBuilder.Entity<MobiPurchase>(entity =>
            {
                entity.ToTable("MOBI_PURCHASE");

                entity.Property(e => e.BatteryNumber).HasMaxLength(100);

                entity.Property(e => e.ChargerType).HasMaxLength(20);

                entity.Property(e => e.Color).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Gst).HasColumnName("GST");

                entity.Property(e => e.Imeinumber)
                    .HasMaxLength(100)
                    .HasColumnName("IMEINumber");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDate).HasColumnType("date");

                entity.Property(e => e.PurchaserAddress).IsUnicode(false);

                entity.Property(e => e.PurchaserName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber).HasMaxLength(100);

                entity.Property(e => e.Sgst).HasColumnName("SGST");

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.MobiPurchases)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_PURCHASE_SUB_CATAGORY_Id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MobiPurchases)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_PURCHASE_CATAGORY_Id");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MobiPurchases)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_PURCHASE_STATUS_Id");
            });

            modelBuilder.Entity<MobiPurchaseProductStock>(entity =>
            {
                entity.ToTable("MOBI_PURCHASE_PRODUCT_Stock");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Gst).HasColumnName("GST");

                entity.Property(e => e.Imeinumber)
                    .HasMaxLength(100)
                    .HasColumnName("IMEINumber");

                entity.Property(e => e.Sgst).HasColumnName("SGST");

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.MobiPurchaseProductStocks)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_PURCHASE_PRODUCT_STOCK_SUB_CATAGORY_Id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MobiPurchaseProductStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_PURCHASE_PRODUCT_STOCK_CATAGORY_Id");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.MobiPurchaseProductStocks)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_PURCHASE_PRODUCT_STOCK_PURCHASE_Id");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MobiPurchaseProductStocks)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_PURCHASE_PRODUCT_STOCK_STATUS_Id");
            });

            modelBuilder.Entity<MobiState>(entity =>
            {
                entity.ToTable("MOBI_STATE");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYId");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MobiStates)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_STATE_COUNTRY_Id");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.MobiStates)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_STATE_STATUS_Id");
            });

            modelBuilder.Entity<MobiStatus>(entity =>
            {
                entity.ToTable("MOBI_STATUS");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("date");
            });

            modelBuilder.Entity<MobiSubCatagory>(entity =>
            {
                entity.ToTable("MOBI_SUB_CATAGORY");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.HasOne(d => d.Catagory)
                    .WithMany(p => p.MobiSubCatagories)
                    .HasForeignKey(d => d.CatagoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_SUB_CATAGORY_CATAGORY_Id");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MobiSubCatagories)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOBI_SUB_CATAGORY_STATUS_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
