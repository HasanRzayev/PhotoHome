
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

namespace UltraWebsite.Models.Configurations
{
    public class CatagoryConfigration : IEntityTypeConfiguration<Catagory>
    {
        public int index { get; set; }




        public void Configure(EntityTypeBuilder<Catagory> builder)
        {
            index = 1;
            builder.HasData(new Catagory { Id = index++, Name = "Kitab" });
            builder.HasData(new Catagory { Id = index++, Name = " Kadin    " });
            builder.HasData(new Catagory { Id = index++, Name = " Giyim " });
            builder.HasData(new Catagory { Id = index++, Name = "Elbise    " });
        }

    }
}
