﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhotoHome.Data;

#nullable disable

namespace PhotoHome.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PhotoHome.Models.Entity.Catagory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Catagories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kitab"
                        },
                        new
                        {
                            Id = 2,
                            Name = " Kadin    "
                        },
                        new
                        {
                            Id = 3,
                            Name = " Giyim "
                        },
                        new
                        {
                            Id = 4,
                            Name = "Elbise    "
                        });
                });

            modelBuilder.Entity("PhotoHome.Models.Entity.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DownloadCount")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("catagory_id")
                        .HasColumnType("int");

                    b.Property<string>("user_id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("catagory_id");

                    b.HasIndex("user_id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Wallpapers/683",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?3D Renders/973",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Travel/357",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Nature/357",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Street Photography/830",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Experimental/6",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 7,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Textures & Patterns/604",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 8,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Architecture & Interiors/860",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 9,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Fashion & Beauty/966",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 10,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Film/896",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 11,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Food & Drink/83",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 12,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?People/734",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 13,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Spirituality/479",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 14,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Business & Work/709",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 15,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Athletics/346",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 16,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Health & Wellness/945",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 17,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Current Events/409",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        },
                        new
                        {
                            Id = 18,
                            Description = "Bomba",
                            DownloadCount = 24,
                            ImageUrl = "https://source.unsplash.com/random/?Arts & Culture/281",
                            LikeCount = 24,
                            Title = "Super",
                            catagoryid = 1
                        });
                });

            modelBuilder.Entity("PhotoHome.Models.Entity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PhotoHome.Models.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PhotoHome.Models.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhotoHome.Models.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PhotoHome.Models.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PhotoHome.Models.Entity.Picture", b =>
                {
                    b.HasOne("PhotoHome.Models.Entity.Catagory", "catagory")
                        .WithMany("Images")
                        .HasForeignKey("catagory_id");

                    b.HasOne("PhotoHome.Models.Entity.User", "user")
                        .WithMany("Images")
                        .HasForeignKey("user_id");

                    b.Navigation("catagory");

                    b.Navigation("user");
                });

            modelBuilder.Entity("PhotoHome.Models.Entity.Catagory", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("PhotoHome.Models.Entity.User", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
