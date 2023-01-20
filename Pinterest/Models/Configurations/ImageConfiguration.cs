using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Entity;
using System.Drawing;

using System.Net;
using System.Reflection.Metadata;
using CloudinaryDotNet;
using System.Net;
using System.IO;

namespace PhotoHome.Models.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Picture>
    {

        public int index { get; set; }

        public List<string> Catagories { get; set; }

        int numImagesAvailable = 988;

        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            index = 1;
            Catagories = new List<string>();
            Catagories.Add("Wallpapers");
            Catagories.Add("3D Renders");
            Catagories.Add("Travel");
            Catagories.Add("Nature");
            Catagories.Add("Street Photography");
            Catagories.Add("Experimental");
            Catagories.Add("Textures & Patterns");
            Catagories.Add("Architecture & Interiors");
            Catagories.Add("Fashion & Beauty");
            Catagories.Add("Film");
            Catagories.Add("Food & Drink");
            Catagories.Add("People");
            Catagories.Add("Spirituality");
            Catagories.Add("Business & Work");
            Catagories.Add("Athletics");
            Catagories.Add("Health & Wellness");
            Catagories.Add("Current Events");
            Catagories.Add("Arts & Culture");

            Uri url = new Uri("https://burst.shopify.com/food");

            WebClient client = new WebClient();
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            List<string> list = new List<string>();
            //HtmlAgilityPack.HtmlNodeCollection basliqlar = dokuman.DocumentNode.SelectNodes("//section//a");
            int number = 0;
            var nodes = dokuman.DocumentNode.SelectNodes("//img");
            Random rnd = new Random();
            //for (int j = 0; j < 1; j++)
            //{
            //    for (int i = 0; i < 18; i++)
            //    {
            //        int randomImageIndex = rnd.Next(1, numImagesAvailable);



            //        //builder.HasData(new Image { Id = index++, ImageUrl = $"https://source.unsplash.com/collection/{collectionID}/{imageWidth}x{imageHeight}/?sig={randomImageIndex}", catagory_id = 1, user_id = "1", LikeCount = 24, DownloadCount = 24 });

            //        builder.HasData(new Picture { Id = index++, Title = "Super", Description = "Bomba", ImageUrl = $"https://source.unsplash.com/random/?{Catagories[i]}/{randomImageIndex}", catagory_id = 1, LikeCount = 24, DownloadCount = 24 });


            //        System.Threading.Thread.Sleep(10);
            //    }
            //}
            for (int i = 0; i < 2; i++)
            {
                foreach (var src in nodes)
                {



                    builder.HasData(new Picture { Id = index++, Title = "Super", Description = "Bomba", ImageUrl = src.Attributes["src"].Value, catagory_id = 1, LikeCount = 24, DownloadCount = 24 });



                }
            }
            
        }





    }


}
