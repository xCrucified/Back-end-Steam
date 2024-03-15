﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using data_access.data;

#nullable disable

namespace data_access.Migrations
{
    [DbContext(typeof(SteamDbContext))]
    partial class SteamDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
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

            modelBuilder.Entity("data_access.data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 36,
                            Name = "BattleRoyale"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Educational"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Multiplayer"
                        },
                        new
                        {
                            Id = 18,
                            Name = "MMORPG"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Indie"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Military"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Historical"
                        },
                        new
                        {
                            Id = 20,
                            Name = "FPS"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Anime"
                        },
                        new
                        {
                            Id = 5,
                            Name = "RPG"
                        },
                        new
                        {
                            Id = 29,
                            Name = "BoardGame"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Casual"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Coop"
                        },
                        new
                        {
                            Id = 28,
                            Name = "CardGame"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Cyberpunk"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Esports"
                        },
                        new
                        {
                            Id = 30,
                            Name = "FreeToPlay"
                        });
                });

            modelBuilder.Entity("data_access.data.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = 10,
                            Name = "UnitedStates"
                        },
                        new
                        {
                            Id = 5,
                            Name = "India"
                        },
                        new
                        {
                            Id = 9,
                            Name = "UnitedKingdom"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Canada"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Brazil"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Japan"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Mexico"
                        },
                        new
                        {
                            Id = 8,
                            Name = "SouthAfrica"
                        });
                });

            modelBuilder.Entity("data_access.data.Entities.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(49);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TimeProgress")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Editions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 5,
                            Description = "Doesn't exist!",
                            Discount = 0,
                            ImgUrl = "https://i.pinimg.com/736x/45/c8/7b/45c87b4b7852f71b49f794ab98f6c6a5.jpg",
                            Name = "Dota 2",
                            Price = 420m,
                            TimeProgress = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 4,
                            Description = "Football simulation game",
                            Discount = 15,
                            ImgUrl = "https://example.com/fifa22.jpg",
                            Name = "FIFA 22",
                            Price = 59.99m,
                            TimeProgress = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Action role-playing game",
                            Discount = 10,
                            ImgUrl = "https://example.com/ac_valhalla.jpg",
                            Name = "Assassin's Creed Valhalla",
                            Price = 49.99m,
                            TimeProgress = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Sandbox game",
                            Discount = 5,
                            ImgUrl = "https://example.com/minecraft.jpg",
                            Name = "Minecraft",
                            Price = 29.99m,
                            TimeProgress = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Action role-playing game",
                            Discount = 20,
                            ImgUrl = "https://example.com/witcher3.jpg",
                            Name = "The Witcher 3: Wild Hunt",
                            Price = 39.99m,
                            TimeProgress = 0
                        });
                });

            modelBuilder.Entity("data_access.data.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<bool?>("Rate")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EditionId");

                    b.HasIndex("UserId1");

                    b.ToTable("Reviews", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Good Game!!",
                            EditionId = 1,
                            Rate = false,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Bad Game!!",
                            EditionId = 2,
                            Rate = true,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Ok Game!!",
                            EditionId = 3,
                            Rate = true,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Comment = "Pretty Good Game!!",
                            EditionId = 4,
                            Rate = true,
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            Comment = "Normal Game!!",
                            EditionId = 5,
                            Rate = false,
                            UserId = 5
                        });
                });

            modelBuilder.Entity("data_access.data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Games")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

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

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

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
                    b.HasOne("data_access.data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("data_access.data.Entities.User", null)
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

                    b.HasOne("data_access.data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("data_access.data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("data_access.data.Entities.Edition", b =>
                {
                    b.HasOne("data_access.data.Entities.Category", "Category")
                        .WithMany("Editions")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("data_access.data.Entities.Review", b =>
                {
                    b.HasOne("data_access.data.Entities.Edition", "Edition")
                        .WithMany("Reviews")
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("data_access.data.Entities.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId1");

                    b.Navigation("Edition");

                    b.Navigation("User");
                });

            modelBuilder.Entity("data_access.data.Entities.User", b =>
                {
                    b.HasOne("data_access.data.Entities.Country", "Country")
                        .WithMany("Users")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("data_access.data.Entities.Category", b =>
                {
                    b.Navigation("Editions");
                });

            modelBuilder.Entity("data_access.data.Entities.Country", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("data_access.data.Entities.Edition", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("data_access.data.Entities.User", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
