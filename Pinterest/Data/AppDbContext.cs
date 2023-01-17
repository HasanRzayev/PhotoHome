
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Configurations;
using PhotoHome.Models.Entity;
using System.Collections.Generic;
using System.Reflection.Emit;
using UltraWebsite.Models.Configurations;

namespace PhotoHome.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Picture> Images { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Picture>()
                .HasOne(s => s.catagory)
                .WithMany(g => g.Images)
                .HasForeignKey(s => s.catagory_id);
            modelBuilder.Entity<Picture>()
               .HasOne(s => s.user)
               .WithMany(g => g.Created_Images)
               .HasForeignKey(s => s.user_id);
            modelBuilder.Entity<Picture>()
              .HasOne(s => s.user_liked)
              .WithMany(g => g.Liked_Images)
              .HasForeignKey(s => s.user_id_liked);
            modelBuilder.ApplyConfiguration(new CatagoryConfigration());
            //modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());

        }
    }

}
