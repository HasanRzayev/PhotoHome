
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
using PhotoHome.Models.Configurations;

namespace UltraWebsite.Models.Configurations
{
    public class Tag_Configurations : IEntityTypeConfiguration<Tag>
    {
        public int index { get; set; }

        public Default fake { get; set; }
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            index = 1;
            fake = new Default();
            foreach (var item in fake.GetTagNames())
            {
                builder.HasData(new Tag { Id = index++, Name = item });
            }

        }

    }
}
