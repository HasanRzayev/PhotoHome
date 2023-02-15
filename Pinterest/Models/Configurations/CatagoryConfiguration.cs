
using Microsoft.AspNetCore.DataProtection;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.Design;
using System.Net;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Security.Policy;
using System;
using System.Threading;
using System.Threading.Tasks;
using PhotoHome.Models.Entity;
using CloudinaryDotNet.Actions;
using PhotoHome.Models;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace UltraWebsite.Models.Configurations
{
    public class CatagoryConfigration : IEntityTypeConfiguration<Catagory>
    {
        public int index { get; set; }
        public int number { get; set; }
        public int cata { get; set; }

        int Max(int number)
        {
            if (number % 10 == 0) return cata++;
            number++;
            return cata;
        }
        public void Configure(EntityTypeBuilder<Catagory> builder)
        {
            index = 1;

            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/bustling-city-street-in-india.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "around the orld          " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/office-flat-lay-on-wooden-desk-with-catch-tray.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "work from home            " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/a-note-just-to-say-you-are-enough.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "mental health               " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/autumn-photographer-taking-picture.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "female photographer         " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/large-fall-leaf-in-hand.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "fall                          " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/creamy-cold-drink-sits-on-a-wooden-table.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "coffee                       " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/woman-resting-her-feet-by-the-window.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "home                          " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/brushes-blossoms.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "beauty                        " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/ready-set-snow.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "fitness                       " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/a-minimal-yet-cosy-workspace.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "office                        " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/kids-show-mom-some-love.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "kids                          " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/looking-back-through-arches-in-india.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "india                         " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/two-tone-ink-cloud.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "wallpapers                    " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/a-tattooed-hand-doing-the-sign-for-i-love-you.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "sign language               " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/model-with-leather-jacket-over-shoulders.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "womens fashion              " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/black-and-white-crosswalk.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "black and white           " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/mixing-board-black-and-white.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "technology                    " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/person-in-a-white-shirt-sits-in-front-of-a-brick-wall.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "mens fashion                " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/ice-cracks-on-a-frozen-sea.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "textures                      " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/a-drop-of-pink-and-yellow-paint-in-water.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "background                    " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/team-working-together-with-laptops.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "business                      " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/blue-lake-and-rocky-mountains.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "nature                        " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/ripe-red-strawberries-in-a-white-bowl.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "food                          " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/man-holding-shipping-box-on-red-brick.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "product                       " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/person-stands-by-a-brick-wall-and-holds-a-book-open.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "jewelry                       " });
            builder.HasData(new Catagory { Id = index++, ImageUrl="https://burst.shopifycdn.com/photos/triangle-goat-collar.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "animal                        " });
            builder.HasData(new Catagory { Id = index++, ImageUrl= "https://burst.shopifycdn.com/photos/incredible-balance-yoga-posing.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0",  Name = "yoga                        " });

        }
    }
}
