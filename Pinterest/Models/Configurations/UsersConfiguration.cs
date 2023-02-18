using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using PhotoHome.Data;

namespace PhotoHome.Models.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public int index { get; set; }


        public void Configure(EntityTypeBuilder<User> builder)
        {
            index = 1;

            builder.HasData(new User { Id = "1", UserName= "Hesen_Rzayev", FirstName = "Hesen", Email = "hsnrz2002@gmail.com", LastName = "Rzayev" , ImageUrl= "~\\images\\user\\adilabbasov.png" });
            builder.HasData(new User { Id = "2",  UserName= "Adil_Abbasov", FirstName = "Adil", Email = "ffff@gmail.com", LastName = "Abbasov"});
        
        }

    }
}
