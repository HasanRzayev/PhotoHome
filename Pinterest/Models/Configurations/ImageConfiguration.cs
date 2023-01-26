using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Entity;
using System.Drawing;

using System.Net;
using System.Reflection.Metadata;
using CloudinaryDotNet;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace PhotoHome.Models.Configurations
{


    public class ImageConfiguration : IEntityTypeConfiguration<Picture>
    {

        public int index { get; set; } = 1;



        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            index = 1;
            Uri url = new Uri("https://picjumbo.com/");
            WebClient client = new WebClient();
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            List<string> list = new List<string>();
            int number = 0;
            var nodes = dokuman.DocumentNode.SelectNodes("//div[@class='home_categories']//a");
            string tam_link = "https://picjumbo.com/";
            List<Picture> images = new List<Picture>();
            foreach (var src in nodes)
            {
                string link = tam_link + src.Attributes["href"].Value;


                Uri url_2 = new Uri(link);

                WebClient client_2 = new WebClient();
                string html_2 = client_2.DownloadString(url_2);
                HtmlAgilityPack.HtmlDocument dokuman_2 = new HtmlAgilityPack.HtmlDocument();
                dokuman_2.LoadHtml(html_2);
                var option = dokuman_2.DocumentNode.SelectNodes("//img[@class='image']");
                foreach (var src_2 in option)
                {

                    builder.HasData((new Picture { Id = index++, Title = "Super", Description = "Bomba", ImageUrl = src_2.Attributes["src"].Value, catagory_id = 1, LikeCount = 24, DownloadCount = 24 }));
                }
            }


        }





    }


}
