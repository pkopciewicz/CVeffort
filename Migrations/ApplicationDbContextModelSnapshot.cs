﻿// <auto-generated />
using System;
using CVeffort.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CVeffort.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CVeffort.Models.DamagedUnits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("A1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("G9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("H9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PipeEnding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WhenAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("WhoAdded")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DamagedUnits");
                });

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}