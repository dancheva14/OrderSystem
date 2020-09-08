using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Database
{
    public class OrderSystemDbContext : IdentityDbContext<User, Role, string>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                   .Property(e => e.Id)
                   .ValueGeneratedOnAdd();

            builder.Entity<Role>()
                   .Property(e => e.Id)
                   .ValueGeneratedOnAdd();

            builder
                .Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(d => d.User)
                .HasForeignKey(d => d.UserId);


            builder
                .Entity<Brand>()
                .HasMany(u => u.BrandDetails)
                .WithOne(d => d.Brand)
                .HasForeignKey(d => d.BrandId);

            builder
                .Entity<Order>()
                .HasMany(u => u.OrderDetails)
                .WithOne(d => d.Order)
                .HasForeignKey(d => d.OrderId);

            builder
                .Entity<Order>()
                .HasOne(d => d.Partner)
                .WithMany(g => g.Orders)
                .HasPrincipalKey(i => i.PartnerId)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Order>()
                .HasOne(d => d.User)
                .WithMany(g => g.Orders)
                .HasPrincipalKey(i => i.Id)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Order>()
                .HasOne(d => d.Status)
                .WithMany(g => g.Orders)
                .HasPrincipalKey(i => i.StatusId)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Part>()
                .HasOne(p => p.Category)
                .WithMany(a => a.Parts)
                .HasPrincipalKey(a => a.CategoryId)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Part>()
                .HasOne(p => p.BrandDetail)
                .WithMany(a => a.Parts)
                .HasPrincipalKey(a => a.BrandDetailId)
                .HasForeignKey(b => b.BrandDetailId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.EnableSensitiveDataLogging();

            builder.UseSqlServer("Server=.;Database=OrderSystemDatabase;User Id=sa;Password=Micr0!nvest;");
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandDetail> BrandDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}