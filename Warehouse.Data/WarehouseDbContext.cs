using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Common.Entities;

namespace Warehouse.Data
{
    public class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext()
           : base("WarehouseDbContext")
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<DocumentItem> DocumentItems { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey(e => e.Id);
            modelBuilder.Entity<User>()
               .Property(e => e.Id)
               .HasColumnName("UserId");

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .HasColumnName("Username")
                .IsRequired();

            modelBuilder.Entity<User>()
               .Property(e => e.Password)
               .HasColumnName("Password")
               .IsRequired();

            modelBuilder.Entity<DocumentItem>().HasRequired(u => u.User).WithMany().Map(m => m.MapKey("UserId"));

            modelBuilder.Entity<DocumentItem>().ToTable("ListDocuments");
            modelBuilder.Entity<DocumentItem>().HasKey(e => e.Id);
            modelBuilder.Entity<DocumentItem>()
             .Property(e => e.Id)
             .HasColumnName("DocId");

            modelBuilder.Entity<DocumentItem>()
                .Property(e => e.Date)
               .HasColumnName("Date")
               .IsRequired();

            modelBuilder.Entity<DocumentItem>()
              .Property(e => e.ClientNumber)
              .HasColumnName("ClientNumber")
              .IsRequired();

            modelBuilder.Entity<DocumentItem>()
             .Property(e => e.ClientNumber)
             .HasColumnName("ClientNumber")
             .IsRequired();

            modelBuilder.Entity<DocumentItem>()
             .Property(e => e.Title)
             .HasColumnName("Title")
             .IsRequired();

            modelBuilder.Entity<DocumentItem>().HasMany<Product>(u => u.Products).WithRequired(u => u.DocumentItem).Map(m => m.MapKey("DocId"));

            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().HasKey(e => e.Id);
            modelBuilder.Entity<Product>()
              .Property(e => e.Id)
              .HasColumnName("ProdId");

            modelBuilder.Entity<Product>()
               .Property(e => e.Title)
               .HasColumnName("Title")
               .IsRequired();

            modelBuilder.Entity<Product>()
              .Property(e => e.Amount)
              .HasColumnName("Amount")
              .IsRequired();

            modelBuilder.Entity<Product>()
              .Property(e => e.NetPrice)
              .HasColumnName("NetPrice")
              .IsRequired();

            modelBuilder.Entity<Product>()
             .Property(e => e.GrossPrice)
             .HasColumnName("GrossPrice")
             .IsRequired();
        }
        }
}
