﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission06_allipope.Models;

namespace mission06_allipope.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20230209222659_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("mission06_allipope.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Adventure/Comedy",
                            Director = "Taika Watiti",
                            Edited = false,
                            Rating = "pg13",
                            Title = "Hunt for the Wilderpeople",
                            Year = (short)2016
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Comedy/Drama",
                            Director = "Nancy Meyers",
                            Edited = false,
                            Rating = "pg13",
                            Title = "The Intern",
                            Year = (short)2015
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Musical",
                            Director = "Phyllida Lloyd",
                            Edited = false,
                            Rating = "pg13",
                            Title = "Mamma Mia!",
                            Year = (short)2008
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
