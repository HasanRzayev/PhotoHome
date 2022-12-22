using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Entity;

namespace PhotoHome.Models.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public int index { get; set; }




        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            index = 1;
            builder.HasData(new AppUser { Id = (index++).ToString(),UserName="Boss",PasswordHash="boss"});
          
        }

    }
}
