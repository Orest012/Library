using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System.Linq;

namespace New_Project.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDBContext _db;

        public BookController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Book> obj = _db.Books.ToList();
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            Book obj = _db.Books.FirstOrDefault(u => u.IdBook == id);
            _db.Books.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            Book obj = _db.Books.FirstOrDefault(u => u.IdBook == id);

            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Book obj)
        {
            _db.Books.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {

            Book obj = _db.Books.FirstOrDefault(u => u.IdBook == id);
            BookDetail detail = _db.BookDetails.FirstOrDefault(u => u.Book_Id == id);
            if (detail != null)
            {

                obj.BookDetail = detail;

                return View(obj);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Author(int? id)
        {

            //Book obj = _db.Books.FirstOrDefault(u => u.IdBook == id);
            //BookAuthorMap author = new BookAuthorMap();
            ////  author.Author = _db.Authors.FirstOrDefault(u => u.AuthorId == id);

            //if (author != null)
            //{
            //    List<BookAuthorMap> list_authors = new List<BookAuthorMap>();
            //    list_authors.Add(author);
            //    obj.BookAuthorMap = list_authors;
            //    return View(obj);
            //}
            //else
            //{
            //    return RedirectToAction("Index");
            //}

            BookAuthorMap bookAuthor = new BookAuthorMap();
            bookAuthor.Book = _db.Books.FirstOrDefault(u => u.IdBook == id);
            bookAuthor.Book_Id = bookAuthor.Book.IdBook;

            bookAuthor.Author = _db.Authors.ToList();
            return View(bookAuthor);


        }

        [HttpPost]
        public IActionResult Display(BookAuthorMap bookAuthorMap)
        {
            BookAuthorVM bookAuthorVM = new BookAuthorVM();

            Book book = _db.Books.FirstOrDefault(u => u.IdBook == bookAuthorMap.Book_Id);
            Author author = _db.Authors.FirstOrDefault(u => u.AuthorId == bookAuthorMap.Author_Id);

            bookAuthorVM.Book = book;
            bookAuthorVM.IdBook = book.IdBook;
            bookAuthorVM.AuthorList = new List<Author>();
            bookAuthorVM.AuthorList.Add(author);

            return View(bookAuthorVM);

        }

        [HttpPost]

        public IActionResult Author(BookAuthorVM bookAuthorMap)
        {
            //BookAuthorVM bookAuthorVM = new BookAuthorVM();

            //Book book = _db.Books.FirstOrDefault(u => u.IdBook == bookAuthorMap.Book_Id);
            //Author author = _db.Authors.FirstOrDefault(u => u.AuthorId == bookAuthorMap.Author_Id);

            //bookAuthorVM.Book = book;
            //bookAuthorVM.IdBook = book.IdBook;
            //bookAuthorVM.AuthorList = new List<Author>();
            //bookAuthorVM.AuthorList.Add(author);

            return View();
        }

        //public IActionResult Edit(int? id)
        //{
        //    Publisher obj = _db.Publishers.FirstOrDefault(u => u.Publisher_Id == id);

        //    return View(obj);
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(Publisher obj)
        //{

        //    _db.Publishers.Update(obj);
        //    _db.SaveChanges();
        //    return RedirectToAction("Publisher_Index");
        //}

        //public IActionResult Create()
        //{
        //    Publisher obj = new Publisher();
        //    return View(obj);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(Publisher obj)
        //{
        //    _db.Publishers.Add(obj);
        //    _db.SaveChanges();
        //    return RedirectToAction("Publisher_Index");
        //}
    }
}
