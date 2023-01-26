
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
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
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Image_Tag> Image_Tags { get; set; }
        public DbSet<Image_Like> Image_Likes { get; set; }


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
            modelBuilder.Entity<Image_Tag>()
                .HasKey(bc => new { bc.Image_Id, bc.Tag_Id });
            modelBuilder.Entity<Image_Tag>()
                .HasOne(bc => bc.Image)
                .WithMany(b => b.Image_Tags)
                .HasForeignKey(bc => bc.Image_Id);
            modelBuilder.Entity<Image_Tag>()
                .HasOne(bc => bc.Tag)
                .WithMany(c => c.Image_Tags)
                .HasForeignKey(bc => bc.Tag_Id);
            modelBuilder.Entity<Image_Like>()
             .HasKey(bc => new { bc.Image_Id, bc.user_id });
            modelBuilder.Entity<Image_Like>()
                .HasOne(bc => bc.Image)
                .WithMany(b => b.Image_Likes)
                .HasForeignKey(bc => bc.Image_Id);
            modelBuilder.Entity<Image_Like>()
                .HasOne(bc => bc.user)
                .WithMany(c => c.Image_Likes)
                .HasForeignKey(bc => bc.user_id);
            modelBuilder.ApplyConfiguration(new CatagoryConfigration());
            //modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());

        }
    }

}
