﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240302203447_AddBookAuthorMap")]
    partial class AddBookAuthorMap
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fluent_AuthorFluent_Book", b =>
                {
                    b.Property<int>("AuthorsAuthor_id")
                        .HasColumnType("int");

                    b.Property<int>("BooksIdBook")
                        .HasColumnType("int");

                    b.HasKey("AuthorsAuthor_id", "BooksIdBook");

                    b.HasIndex("BooksIdBook");

                    b.ToTable("Fluent_AuthorFluent_Book");
                });

            modelBuilder.Entity("Models.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Models.Models.Book", b =>
                {
                    b.Property<int>("IdBook")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBook"));

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBook");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            IdBook = 1,
                            ISBN = "12312",
                            Price = 10,
                            Title = "Harry Potter | Chapter 1"
                        },
                        new
                        {
                            IdBook = 2,
                            ISBN = "56712",
                            Price = 8,
                            Title = "Harry Potter | Chapter 2"
                        },
                        new
                        {
                            IdBook = 3,
                            ISBN = "aaa",
                            Price = 10,
                            Title = "Harry Potter | Chapter 3"
                        },
                        new
                        {
                            IdBook = 4,
                            ISBN = "ddsa",
                            Price = 8,
                            Title = "Harry Potter | Chapter 4"
                        },
                        new
                        {
                            IdBook = 5,
                            ISBN = "aaa",
                            Price = 10,
                            Title = "Harry Potter | Chapter 5"
                        });
                });

            modelBuilder.Entity("Models.Models.BookAuthorMap", b =>
                {
                    b.Property<int>("Author_Id")
                        .HasColumnType("int");

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.HasKey("Author_Id", "Book_Id");

                    b.HasIndex("Book_Id");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("Models.Models.BookDetail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetail_Id"));

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfChapters")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookDetail_Id");

                    b.HasIndex("Book_Id")
                        .IsUnique();

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("Models.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Models.Models.Fluent_Author", b =>
                {
                    b.Property<int>("Author_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Author_id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_id");

                    b.ToTable("fluent_Authors");
                });

            modelBuilder.Entity("Models.Models.Fluent_Book", b =>
                {
                    b.Property<int>("IdBook")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBook"));

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Publisher_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBook");

                    b.HasIndex("Publisher_Id");

                    b.ToTable("fluent_Books");
                });

            modelBuilder.Entity("Models.Models.Fluent_BookDetail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetail_Id"));

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfChapters")
                        .HasColumnType("int")
                        .HasColumnName("NumberOfChapters");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookDetail_Id");

                    b.HasIndex("Book_Id")
                        .IsUnique();

                    b.ToTable("Fluent_BookDetails", (string)null);
                });

            modelBuilder.Entity("Models.Models.Fluent_Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Publisher_Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("fluent_Publishers");
                });

            modelBuilder.Entity("Models.Models.Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Publisher_Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Models.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategory_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCategory_Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SubCategory_Id");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Fluent_AuthorFluent_Book", b =>
                {
                    b.HasOne("Models.Models.Fluent_Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.Fluent_Book", null)
                        .WithMany()
                        .HasForeignKey("BooksIdBook")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Models.BookAuthorMap", b =>
                {
                    b.HasOne("Models.Models.Author", "Author")
                        .WithMany("BookAuthorMap")
                        .HasForeignKey("Author_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.Book", "Book")
                        .WithMany("BookAuthorMap")
                        .HasForeignKey("Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Models.Models.BookDetail", b =>
                {
                    b.HasOne("Models.Models.Book", "Book")
                        .WithOne("BookDetail")
                        .HasForeignKey("Models.Models.BookDetail", "Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Models.Models.Fluent_Book", b =>
                {
                    b.HasOne("Models.Models.Fluent_Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Publisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Models.Models.Fluent_BookDetail", b =>
                {
                    b.HasOne("Models.Models.Fluent_Book", "Book")
                        .WithOne("BookDetail")
                        .HasForeignKey("Models.Models.Fluent_BookDetail", "Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Models.Models.Author", b =>
                {
                    b.Navigation("BookAuthorMap");
                });

            modelBuilder.Entity("Models.Models.Book", b =>
                {
                    b.Navigation("BookAuthorMap");

                    b.Navigation("BookDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Models.Fluent_Book", b =>
                {
                    b.Navigation("BookDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Models.Fluent_Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
