﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _418FinalProject.Models;

namespace _418FinalProject.Migrations
{
    [DbContext(typeof(DataBankContext))]
    partial class DataBankContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("_418FinalProject.Models.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Question ID");

                    b.Property<string>("Answer1Text")
                        .IsRequired()
                        .HasColumnName("ANS1")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Answer2Text")
                        .IsRequired()
                        .HasColumnName("ANS2")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Answer3Text")
                        .IsRequired()
                        .HasColumnName("ANS3")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Answer4Text")
                        .IsRequired()
                        .HasColumnName("ANS4")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Image")
                        .HasColumnName("Image")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnName("Question Text")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("TrueFalse")
                        .HasColumnName("True False")
                        .HasColumnType("bit");

                    b.HasKey("QuestionID");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("_418FinalProject.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("USER_ID");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("PASSWORD")
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("Type")
                        .HasColumnName("ADMIN")
                        .HasColumnType("BIT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnName("USER_NAME")
                        .HasColumnType("varchar(20)");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
