using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Entity;

namespace PhotoHome.Models.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public int index { get; set; }


        public void Configure(EntityTypeBuilder<User> builder)
        {
            index = 1;
            builder.HasData(new User { Id = "1", UserName= "Polat_Alemdar", FirstName = "Polat", Email = "hsnrz2002@gmail.com", LastName = "Alemdar" });
            builder.HasData(new User { Id = "2",  UserName= "Memati_Bas", FirstName = "Memati", Email = "ffff@gmail.com", LastName = "Bas" });
            builder.HasData(new User { Id = "3",  UserName= "AlpAslan_Cakirbeyli", FirstName = "AlpAslan", Email = "dd@gmail.com", LastName = "Cakirbeyli" });
            builder.HasData(new User { Id = "4",  UserName= "Hizir_Cakirbeyli", FirstName = "Hizir", Email = "sss@gmail.com", LastName = "Cakirbeyli" });
            builder.HasData(new User { Id = "5", UserName = "Ilyas_Cakirbeyli", FirstName = "Ilyas", Email = "aaaa@gmail.com", LastName = "Cakirbeyli" });
        }

    }
}
