//// See https://aka.ms/new-console-template for more information
using DataAccess.Data;
using DataAccess.Migrations;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Hello, World!");

////using (ApplicationDBContext context = new())
////{
////    context.Database.EnsureCreated();
////    if (context.Database.GetPendingMigrations().Count() > 0)
////    {
////        context.Database.Migrate();
////    }
////}

////AddBook();
////GetAllBooks();
//GetBook();
//UpdateBook();
////DeleteBook();
///
AddAuthor();

void AddAuthor()
{
    List<Author> author = new List<Author>(){
        new Author {
                FirstName = "First_Name_1",
                LastName = "Last_Name_1",
                BirthDate = DateTime.Now,
                Location = "Lviv"
        },
        new Author {
                FirstName = "First_Name_2",
                LastName = "Last_Name_2",
                BirthDate = DateTime.Now,
                Location = "Kyiv"
        }
};
}
//    using var context = new ApplicationDBContext();
//    for (int i = 0; i < author.Count; i++)
//    {
//        context.Authors.Add(author[i]);
//    }
//    context.SaveChanges();

//}

//async void DeleteBook()
//{
//    using var context = new ApplicationDBContext();
//    var books = await context.Books.FindAsync(6);
//    context.Books.Remove(books);
//    await context.SaveChangesAsync();
//}

//void UpdateBook()
//{
//    using var context = new ApplicationDBContext();
//    var book = context.Books.Find(7);
//    book.Title = "My_book";
//    context.SaveChanges();
//}

//async void GetBook()
//{
//    using var context = new ApplicationDBContext();
//    //Book book = context.Books.First();
//    //var book = context.Books.Where(u => u.Price == 10);

//    //foreach (var item in book)
//    //{
//    //    Console.WriteLine(item.Title + " - " + item.ISBN);
//    //}

//    //var book = context.Books.FirstOrDefault(u => u.Title == "Harry Potter | Chapter 3");
//    //Console.WriteLine(book.Title + " - " + book.ISBN);


//    //var book = context.Books.Find(5);
//    //Console.WriteLine(book.Title + " - " + book.ISBN);

//    //var book = context.Books.Single(u => u.IdBook == 3);
//    //Console.WriteLine(book.Title + " - " + book.ISBN);

//    //var book_1 = context.Books.Where(u => u.ISBN.Contains("12")).Max(u => u.Price == 10);
//    //var book = context.Books.Where(u => EF.Functions.Like( u.ISBN, "12%"));

//    //foreach (var num in book)
//    //{
//    //    Console.WriteLine(num.Title + " - " + num.ISBN);
//    //}

//    //Sort
//    //var books = context.Books.OrderBy(u => u.Price).OrderByDescending(u => u.IdBook);
//    //foreach (var item in books)
//    //{
//    //   Console.WriteLine(item.Title + " - " + item.ISBN);

//    //}

//    //var new_books = context.Books.OrderBy(u => u.Price).ThenByDescending(u => u.IdBook);
//    //foreach (var item in new_books)
//    //{
//    //    Console.WriteLine(item.Title + " - " + item.ISBN);

//    //}



//    var book = await context.Books.Skip(1).Take(2).ToListAsync();
//    foreach (var item in book)
//    {
//        Console.WriteLine(item.Title + " - " + item.ISBN);

//    }

//}

//void AddBook()
//{
//    Book new_book = new()
//    {
//        Title = "New book1",
//        ISBN = "123",
//        Price = 10
//    };

//    using var context = new ApplicationDBContext();
//    context.Books.Add(new_book);
//    context.SaveChanges();
//}

//void GetAllBooks()
//{
//    using var context = new ApplicationDBContext();
//    var books = context.Books.ToList();
//    foreach (var book in books)
//    {
//        Console.WriteLine(book.Title + " - " + book.ISBN);
//    }

//}

