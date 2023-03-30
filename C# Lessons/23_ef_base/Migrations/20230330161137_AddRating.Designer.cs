﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _23_ef_base.Data;

#nullable disable

namespace _23_ef_base.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20230330161137_AddRating")]
    partial class AddRating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_23_ef_base.Data.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            FirstName = "Ivan",
                            LastName = "Franko"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            FirstName = "Taras",
                            LastName = "Shevchenko"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            FirstName = "Mykola",
                            LastName = "Gogol"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 3,
                            FirstName = "Mark",
                            LastName = "Twain"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 3,
                            FirstName = "Stephen",
                            LastName = "King"
                        });
                });

            modelBuilder.Entity("_23_ef_base.Data.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("_23_ef_base.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = 2,
                            Name = "France"
                        },
                        new
                        {
                            Id = 3,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Italy"
                        },
                        new
                        {
                            Id = 5,
                            Name = "United Kindom"
                        });
                });

            modelBuilder.Entity("_23_ef_base.Data.Author", b =>
                {
                    b.HasOne("_23_ef_base.Data.Country", "Country")
                        .WithMany("Authors")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("_23_ef_base.Data.Book", b =>
                {
                    b.HasOne("_23_ef_base.Data.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("_23_ef_base.Data.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("_23_ef_base.Data.Country", b =>
                {
                    b.Navigation("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}
