using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Entity;
using System.Reflection.Metadata;

namespace PhotoHome.Models.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public int index { get; set; }



        int numImagesAvailable = 988;
        int imageWidth = 480;   
        int imageHeight = 480;
        int collectionID = 928423; 
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            index = 1;
            Random rnd = new Random();
            
            for (int i = 0; i < 50; i++)
            {
                int randomImageIndex = rnd.Next(1, numImagesAvailable);
                //builder.HasData(new Image { Id = index++, ImageUrl = $"https://source.unsplash.com/collection/{collectionID}/{imageWidth}x{imageHeight}/?sig={randomImageIndex}", catagory_id = 1, user_id = "1", LikeCount = 24, DownloadCount = 24 });

                builder.HasData(new Image { Id = index++, ImageUrl = $"https://source.unsplash.com/random/200x200?sig={randomImageIndex}", catagory_id = 1, user_id = "1", LikeCount = 24, DownloadCount = 24 });
                System.Threading.Thread.Sleep(10);
            }





        }

    }
}
