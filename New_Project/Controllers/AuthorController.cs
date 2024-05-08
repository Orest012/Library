using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace New_Project.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDBContext _db;

        public AuthorController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Author_Index()
        {
            List<Author> authors = _db.Authors.ToList();
            return View(authors);
        }

        public IActionResult Delete(int? id)
        {

            Author author = _db.Authors.FirstOrDefault();
            if (author == null)
            {
                return NotFound();
            }

            _db.Authors.Remove(author);
            _db.SaveChanges();
            return RedirectToAction("Author_Index");
        }

        public IActionResult Edit(int? id)
        {
            Author obj = _db.Authors.FirstOrDefault(u => u.AuthorId == id);
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Author obj)
        {
            _db.Authors.Update(obj);
            _db.SaveChangesAsync();
            return RedirectToAction("Author_Index");
        }

        public IActionResult Create()
        {
            Author obj = new Author();   
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Author obj)
        {
            //Category cat = new Category()
            //{
            //    CategoryId = 100,
            //    CategoryName = "cat 100"
            //};
            //_db.Categories.AddAsync(cat);
            //_db.SaveChangesAsync();
         
            _db.Authors.AddAsync(obj);
            _db.SaveChangesAsync();

            return RedirectToAction("Author_Index");
        }
    }

}