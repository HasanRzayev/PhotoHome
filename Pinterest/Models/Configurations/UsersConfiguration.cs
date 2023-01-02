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
            builder.HasData(new User { Id = (index++),FirstName="Boss",Password="boss",Email="hsnrz2002@gmail.com",LastName="aaaaaaaaaaaaa"});
          
        }

    }
}
