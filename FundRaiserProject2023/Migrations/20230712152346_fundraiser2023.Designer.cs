﻿// <auto-generated />
using System;
using FundRaiserProject2023.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FundRaiserProject2023.Migrations
{
    [DbContext(typeof(OurDbContext))]
    [Migration("20230712152346_fundraiser2023")]
    partial class fundraiser2023
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FundRaiserProject2023.Models.Backer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Backers");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectsId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CurrentFunding")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FundingGoal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProjectCreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectCreatorId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.ProjectCreator", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProjectCreators");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.ProjectFunding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AmountContributed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("BackerId")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BackerId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("ProjectFundings");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.ProjectPhotos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PhotoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectsId");

                    b.ToTable("ProjectPhotos");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.ProjectVideos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ProjectsId")
                        .HasColumnType("int");

                    b.Property<string>("VideoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectsId");

                    b.ToTable("ProjectVideos");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.RewardPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("PackageAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PackageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectsId")
                        .HasColumnType("int");

                    b.Property<string>("RewardDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectsId");

                    b.ToTable("RewardPackages");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.Backer", b =>
                {
                    b.HasOne("FundRaiserProject2023.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FundRaiserProject2023.Models.Project", null)
                        .WithMany("Backers")
                        .HasForeignKey("ProjectId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.Category", b =>
                {
                    b.HasOne("FundRaiserProject2023.Models.Project", "Projects")
                        .WithMany()
                        .HasForeignKey("ProjectsId");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.Project", b =>
                {
                    b.HasOne("FundRaiserProject2023.Models.ProjectCreator", "ProjectCreator")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectCreatorId");

                    b.Navigation("ProjectCreator");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.ProjectCreator", b =>
                {
                    b.HasOne("FundRaiserProject2023.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.ProjectFunding", b =>
                {
                    b.HasOne("FundRaiserProject2023.Models.Backer", "Backer")
                        .WithMany("ProjectFundings")
                        .HasForeignKey("BackerId");

                    b.HasOne("FundRaiserProject2023.Models.Project", "Projects")
                        .WithMany("ProjectFundings")
                        .HasForeignKey("ProjectsId");

                    b.Navigation("Backer");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.ProjectPhotos", b =>
                {
                    b.HasOne("FundRaiserProject2023.Models.Project", "Projects")
                        .WithMany("ProjectPhotos")
                        .HasForeignKey("ProjectsId");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.ProjectVideos", b =>
                {
                    b.HasOne("FundRaiserProject2023.Models.Project", "Projects")
                        .WithMany("ProjectVideos")
                        .HasForeignKey("ProjectsId");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.RewardPackage", b =>
                {
                    b.HasOne("FundRaiserProject2023.Models.Project", "Projects")
                        .WithMany("RewardPackages")
                        .HasForeignKey("ProjectsId");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.Backer", b =>
                {
                    b.Navigation("ProjectFundings");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.Project", b =>
                {
                    b.Navigation("Backers");

                    b.Navigation("ProjectFundings");

                    b.Navigation("ProjectPhotos");

                    b.Navigation("ProjectVideos");

                    b.Navigation("RewardPackages");
                });

            modelBuilder.Entity("FundRaiserProject2023.Models.ProjectCreator", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}