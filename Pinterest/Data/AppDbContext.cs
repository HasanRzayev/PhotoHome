using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Configurations;
using PhotoHome.Models.Entity;
using System.Collections.Generic;
using System.Reflection.Emit;
using UltraWebsite.Models.Configurations;

namespace PhotoHome.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Picture> Images { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
  


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Picture>()
                .HasOne(s => s.catagory)
                .WithMany(g => g.Images)
                .HasForeignKey(s => s.catagory_id);
            modelBuilder.Entity<Picture>()
               .HasOne(s => s.user)
               .WithMany(g => g.Images)
               .HasForeignKey(s => s.user_id);
            //modelBuilder.Entity<ProductTag>()
            //   .HasKey(pt => new { pt.ProductId, pt.TagId });
            //modelBuilder.Entity<ProductTag>()
            //   .HasOne(p => p.Product)
            //   .WithMany(p => p.ProductTags)
            //   .HasForeignKey(p => p.ProductId);
            //modelBuilder.Entity<ProductTag>()
            //     .HasOne(p => p.Tag)
            //     .WithMany(p => p.ProductTags)
            //     .HasForeignKey(p => p.TagId);



            //modelBuilder.Entity<Order>()
            //    .HasOne(p => p.Product)
            //    .WithOne(p => p.Order)
            //    .HasForeignKey<Product>(p => p.order_id)
            //    .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.ApplyConfiguration(new CatagoryConfigration());
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());

        }
    }
}
