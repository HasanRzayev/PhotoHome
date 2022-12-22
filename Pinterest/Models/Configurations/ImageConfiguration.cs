using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Entity;

namespace PhotoHome.Models.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public int index { get; set; }




        public void Configure(EntityTypeBuilder<Image> builder)
        {
            index = 1;
            builder.HasData(new Image { Id = index++, ImageUrl= "https://i.pinimg.com/474x/12/0a/aa/120aaa097b9fa597043570f2b3ee2100.jpg",catagory_id=1,user_id="1",LikeCount=24,DownloadCount=24 });
            builder.HasData(new Image { Id = index++, ImageUrl = "https://i.pinimg.com/474x/16/fd/0d/16fd0d1a656ef785e6594e7f54e6a510.jpg", catagory_id = 1, user_id = "1", LikeCount = 24, DownloadCount = 24 });

        }

    }
}
