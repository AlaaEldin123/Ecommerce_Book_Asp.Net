using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Domains;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
#nullable disable

namespace Bookss.Models
{
    public partial class NeStoreWebsiteContext : IdentityDbContext<ApplicationUser>
    {
        public NeStoreWebsiteContext()
        {
        }

        public NeStoreWebsiteContext(DbContextOptions<NeStoreWebsiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbBusinessInfo> TbBusinessInfos { get; set; }
        public virtual DbSet<TbCategory> TbCategories { get; set; }
        public virtual DbSet<TbCustomer> TbCustomers { get; set; }
        public virtual DbSet<TbCustomerItem> TbCustomerItems { get; set; }
        public virtual DbSet<TbItem> TbItems { get; set; }
        public virtual DbSet<TbItemImage> TbItemImages { get; set; }
        public virtual DbSet<TbPurchaseInvoice> TbPurchaseInvoices { get; set; }
        public virtual DbSet<TbPurchaseInvoiceItem> TbPurchaseInvoiceItems { get; set; }
        public virtual DbSet<TbSalesInvoice> TbSalesInvoices { get; set; }
        public virtual DbSet<TbSalesInvoiceItem> TbSalesInvoiceItems { get; set; }
        public virtual DbSet<TbSlider> TbSliders { get; set; }
        public virtual DbSet<TbItemDiscount> TbItemDiscount { get; set; }
        public virtual DbSet<TbSupplier> TbSuppliers { get; set; }
        public virtual DbSet<VwItemCategories> VwItemCategories { get; set; }
        public virtual DbSet<VwItemsOutOfInvoice> VwItemsOutOfInvoices { get; set; }

 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TbBusinessInfo>(entity =>
            {
                entity.HasKey(e => e.BusinessInfoId);

                entity.ToTable("TbBusinessInfo");

                entity.HasIndex(e => e.CutomerId, "IX_TbBusinessInfo_CutomerId")
                    .IsUnique();

                entity.Property(e => e.Budget).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.BusinessCardNumber).HasMaxLength(20);

                entity.HasOne(d => d.Cutomer)
                    .WithOne(p => p.TbBusinessInfo)
                    .HasForeignKey<TbBusinessInfo>(d => d.CutomerId);
            });

            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TbCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TbCustomerItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.CustomerId });

                entity.HasIndex(e => e.CustomerId, "IX_TbCustomerItems_CustomerId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TbCustomerItems)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TbCustomerItems)
                    .HasForeignKey(d => d.ItemId);
            });

            modelBuilder.Entity<TbItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImageName).HasMaxLength(200);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<TbItemImage>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TbItemImages)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbItemImages_TbItems");
            });


            modelBuilder.Entity<TbItemDiscount>(entity =>
            { 

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TbItemDiscount)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbItemDiscounts_TbItems");
            });



            modelBuilder.Entity<TbPurchaseInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TbPurchaseInvoices)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbPurchaseInvoices_TbSuppliers");
            });

            modelBuilder.Entity<TbPurchaseInvoiceItem>(entity =>
            {
                entity.HasKey(e => e.InvoiceItemId);

                entity.Property(e => e.InvoiceItemId).ValueGeneratedNever();

                entity.Property(e => e.InvoicePrice).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Qty).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.TbPurchaseInvoiceItems)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbPurchaseInvoiceItems_TbPurchaseInvoices");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TbPurchaseInvoiceItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbPurchaseInvoiceItems_TbItems");
            });

            modelBuilder.Entity<TbSalesInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.Property(e => e.DelivryDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TbSalesInvoices)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbSalesInvoices_TbCustomers");
            });

            modelBuilder.Entity<TbSalesInvoiceItem>(entity =>
            {
                entity.HasKey(e => e.InvoiceItemId);

                entity.Property(e => e.InvoicePrice).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Qty).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.TbSalesInvoiceItems)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbSalesInvoiceItems_TbSalesInvoices");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TbSalesInvoiceItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbSalesInvoiceItems_TbItems");
            });

            modelBuilder.Entity<TbSlider>(entity =>
            {
                entity.HasKey(e => e.SliderId);

                entity.ToTable("TbSlider");

                entity.Property(e => e.SliderId).ValueGeneratedNever();

                entity.Property(e => e.Descraption).HasMaxLength(200);

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<TbSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK_TbSupplier");

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VwItemCategories>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwItemCategories");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<VwItemsOutOfInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwItemsOutOfInvoices");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoicePrice).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(8, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
