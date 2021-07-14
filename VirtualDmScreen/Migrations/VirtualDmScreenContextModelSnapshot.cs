﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtualDmScreen.Models;

namespace VirtualDmScreen.Migrations
{
    [DbContext(typeof(VirtualDmScreenContext))]
    partial class VirtualDmScreenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VirtualDmScreen.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("VirtualDmScreen.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CharacterId");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique();

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("VirtualDmScreen.Models.DiceRoll", b =>
                {
                    b.Property<int>("DiceRollId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("NumberOfDice")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSides")
                        .HasColumnType("int");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.HasKey("DiceRollId");

                    b.HasIndex("CharacterId");

                    b.ToTable("DiceRolls");
                });

            modelBuilder.Entity("VirtualDmScreen.Models.DmChoice", b =>
                {
                    b.Property<int>("DmChoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DmImgSelectionId")
                        .HasColumnType("int");

                    b.Property<int>("DmTrackSelectionId")
                        .HasColumnType("int");

                    b.HasKey("DmChoiceId");

                    b.HasIndex("DmImgSelectionId");

                    b.HasIndex("DmTrackSelectionId");

                    b.ToTable("DmChoices");

                    b.HasData(
                        new
                        {
                            DmChoiceId = 1,
                            DmImgSelectionId = 1,
                            DmTrackSelectionId = 1
                        });
                });

            modelBuilder.Entity("VirtualDmScreen.Models.DmImgSelection", b =>
                {
                    b.Property<int>("DmImgSelectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ImgPath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DmImgSelectionId");

                    b.ToTable("DmImgSelections");

                    b.HasData(
                        new
                        {
                            DmImgSelectionId = 1,
                            ImgName = "Party of Adventurers",
                            ImgPath = "/img/party.jpg"
                        },
                        new
                        {
                            DmImgSelectionId = 2,
                            ImgName = "White Dragon",
                            ImgPath = "/img/whitedragon.jpg"
                        },
                        new
                        {
                            DmImgSelectionId = 3,
                            ImgName = "Red Dragon",
                            ImgPath = "/img/reddragon.jpg"
                        },
                        new
                        {
                            DmImgSelectionId = 4,
                            ImgName = "Fire Breathing Dragon",
                            ImgPath = "/img/firebreath.jpg"
                        },
                        new
                        {
                            DmImgSelectionId = 5,
                            ImgName = "Age of Sigmar",
                            ImgPath = "/img/AgeOfSigmar.jpg"
                        });
                });

            modelBuilder.Entity("VirtualDmScreen.Models.DmTrackSelection", b =>
                {
                    b.Property<int>("DmTrackSelectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SpotifyTrack")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TrackName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DmTrackSelectionId");

                    b.ToTable("DmTrackSelections");

                    b.HasData(
                        new
                        {
                            DmTrackSelectionId = 1,
                            SpotifyTrack = "7ob4BKZ9yFXI06HvQaUXvp",
                            TrackName = "Dragon Age"
                        },
                        new
                        {
                            DmTrackSelectionId = 2,
                            SpotifyTrack = "2EelmLcDmP1h1BuRUu7h7W",
                            TrackName = "City in the Clouds"
                        },
                        new
                        {
                            DmTrackSelectionId = 3,
                            SpotifyTrack = "18O8Y4mZ2sNOBYBwBR1LVK",
                            TrackName = "Willow's Theme"
                        });
                });

            modelBuilder.Entity("VirtualDmScreen.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Text")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("MessageId");

                    b.HasIndex("CharacterId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("VirtualDmScreen.Models.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.HasDiscriminator().HasValue("ApplicationRole");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "7574d767-72ae-4325-8846-c19d4ca30299",
                            Name = "DM",
                            NormalizedName = "DM"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "b6d90467-ba9c-4393-923e-6b1dd3509594",
                            Name = "Player",
                            NormalizedName = "PLAYER"
                        });
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
                    b.HasOne("VirtualDmScreen.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("VirtualDmScreen.Models.ApplicationUser", null)
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

                    b.HasOne("VirtualDmScreen.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("VirtualDmScreen.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VirtualDmScreen.Models.Character", b =>
                {
                    b.HasOne("VirtualDmScreen.Models.ApplicationUser", "User")
                        .WithOne("Character")
                        .HasForeignKey("VirtualDmScreen.Models.Character", "ApplicationUserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VirtualDmScreen.Models.DiceRoll", b =>
                {
                    b.HasOne("VirtualDmScreen.Models.Character", "Character")
                        .WithMany("DiceRolls")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("VirtualDmScreen.Models.DmChoice", b =>
                {
                    b.HasOne("VirtualDmScreen.Models.DmImgSelection", "DmImgSelection")
                        .WithMany()
                        .HasForeignKey("DmImgSelectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VirtualDmScreen.Models.DmTrackSelection", "DmTrackSelection")
                        .WithMany()
                        .HasForeignKey("DmTrackSelectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DmImgSelection");

                    b.Navigation("DmTrackSelection");
                });

            modelBuilder.Entity("VirtualDmScreen.Models.Message", b =>
                {
                    b.HasOne("VirtualDmScreen.Models.Character", "Character")
                        .WithMany("Messages")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("VirtualDmScreen.Models.ApplicationUser", b =>
                {
                    b.Navigation("Character");
                });

            modelBuilder.Entity("VirtualDmScreen.Models.Character", b =>
                {
                    b.Navigation("DiceRolls");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
