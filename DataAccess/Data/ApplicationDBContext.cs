using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;
using DataAccess.FluentConfig;
using Models;

namespace DataAccess.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Fluent_BookDetail> fluent_BookDetails { get; set; }
        public DbSet<Fluent_Book> fluent_Books { get; set; }
        public DbSet<Fluent_Publisher> fluent_Publishers { get; set; }
        public DbSet<Fluent_Author> fluent_Authors { get; set; }

       // public DbSet<BookAuthorMap> AuthorBook { get; set; }
        public DbSet<BookAuthorMap> BookAuthorMaps { get; set; }
        public DbSet<BookAuthorVM> bookAuthorVMs { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //optionsBuilder.UseSqlServer("Server=.;Database=New_Project;TrustServerCertificate=True;Trusted_Connection=True;").
            //   LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name},Microsoft.Extensions.Logging.LogLevel.Information );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthorMap>().HasKey(ba => new { ba.Author_Id, ba.Book_Id });


            modelBuilder.ApplyConfiguration(new FluentBookDetailConfig());
            modelBuilder.ApplyConfiguration(new FluentConfigBook());
          
            modelBuilder.Entity<Fluent_Author>().HasKey(u=>u.Author_id);
            modelBuilder.Entity<Fluent_Author>().Property(u => u.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Fluent_Author>().Property(u => u.FirstName).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Property(u => u.LastName).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Ignore(u => u.FullName);


            modelBuilder.Entity<Fluent_Publisher>().HasKey(u => u.Publisher_Id);
            modelBuilder.Entity<Fluent_Publisher>().Property(u => u.Name).IsRequired();

            //modelBuilder.Entity<Fluent_BookAuthorMap>().HasKey(u =>  u.Book_Id );

            modelBuilder.Entity<Book>().HasData(
               new Book { IdBook = 1, Title = "Harry Potter | Chapter 1", ISBN = "12312", Price = 10},
               new Book { IdBook = 2, Title = "Harry Potter | Chapter 2", ISBN = "56712", Price = 8 }
               );

            var bookList = new Book[]
            {
                new Book { IdBook = 3, Title = "Harry Potter | Chapter 3", ISBN = "aaa", Price = 10},
                new Book { IdBook = 4, Title = "Harry Potter | Chapter 4", ISBN = "ddsa", Price = 8},
                new Book { IdBook = 5, Title = "Harry Potter | Chapter 5", ISBN = "aaa", Price = 10},

            };

            modelBuilder.Entity<Book>().HasData(bookList);
            //List<Author> obj = new List<Author>()
            //{
            //    new Author { }
            //};

            //var bookAuthorVMList = new BookAuthorVM()
            //{
            //   IdBook = 1,
            //   Book = { IdBook = 1, Title = "Harry Potter | Chapter 1", ISBN = "12312", Price = 10},
            //   AuthorList = new Author[] {
            //   }

            //};
            //modelBuilder.Entity<Publisher>().HasData(
            //    new Publisher { Publisher_Id = 1, Name = "Pub 1", Location = "Loc 1" },
            //    new Publisher { Publisher_Id = 2, Name = "Pub 2", Location = "Loc 2" },
            //    new Publisher { Publisher_Id = 3, Name = "Pub 3", Location = "Loc 3" }

            //    );

            //List<Author> author = new List<Author>(){
            //        new Author {
            //            Author_id = 1,
            //                FirstName = "First_Name_1",
            //                LastName = "Last_Name_1",
            //                BirthDate = DateTime.Now,
            //                Location = "Lviv"
            //        },
            //        new Author {
            //            Author_id = 2,
            //                FirstName = "First_Name_2",
            //                LastName = "Last_Name_2",
            //                BirthDate = DateTime.Now,
            //                Location = "Kyiv"
            //        }
            //};

            //modelBuilder.Entity<Author>().HasData(author);

        }
    }
}
