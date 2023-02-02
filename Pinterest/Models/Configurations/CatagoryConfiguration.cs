
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




        public void Configure(EntityTypeBuilder<Catagory> builder)
        {
            index = 1;
     
            builder.HasData(new Catagory { Id = index++, Name = "around - the - world          " });
            builder.HasData(new Catagory { Id = index++, Name = "work - from - home            " });
            builder.HasData(new Catagory { Id = index++, Name = "mental - health               " });
            builder.HasData(new Catagory { Id = index++, Name = "female - photographer         " });
            builder.HasData(new Catagory { Id = index++, Name = "fall                          " });
            builder.HasData(new Catagory { Id = index++, Name = " coffee                       " });
            builder.HasData(new Catagory { Id = index++, Name = "home                          " });
            builder.HasData(new Catagory { Id = index++, Name = "beauty                        " });
            builder.HasData(new Catagory { Id = index++, Name = "fitness                       " });
            builder.HasData(new Catagory { Id = index++, Name = "office                        " });
            builder.HasData(new Catagory { Id = index++, Name = "kids                          " });
            builder.HasData(new Catagory { Id = index++, Name = "india                         " });
            builder.HasData(new Catagory { Id = index++, Name = "wallpapers                    " });
            builder.HasData(new Catagory { Id = index++, Name = "sign - language               " });
            builder.HasData(new Catagory { Id = index++, Name = "womens - fashion              " });
            builder.HasData(new Catagory { Id = index++, Name = "black - and - white           " });
            builder.HasData(new Catagory { Id = index++, Name = "technology                    " });
            builder.HasData(new Catagory { Id = index++, Name = "mens - fashion                " });
            builder.HasData(new Catagory { Id = index++, Name = "textures                      " });
            builder.HasData(new Catagory { Id = index++, Name = "background                    " });
            builder.HasData(new Catagory { Id = index++, Name = "business                      " });
            builder.HasData(new Catagory { Id = index++, Name = "nature                        " });
            builder.HasData(new Catagory { Id = index++, Name = "food                          " });
            builder.HasData(new Catagory { Id = index++, Name = "product                       " });
            builder.HasData(new Catagory { Id = index++, Name = "jewelry                       " });
            builder.HasData(new Catagory { Id = index++, Name = "animal                        " });
            builder.HasData(new Catagory { Id = index++, Name = "yoga                        " });

        }
    }
}
