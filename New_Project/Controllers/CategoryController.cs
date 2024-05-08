using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Models.Models;
using System.ComponentModel.DataAnnotations;

namespace New_Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;

        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> objList = _db.Categories.ToList();
            return View(objList);
        }

        public IActionResult Upsert(int? id)
        {
            Category obj = new();
            if (id == null || id == 0)
            {
                return View(obj);
            }

            obj = _db.Categories.FirstOrDefault(u => u.CategoryId == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Upsert(Category obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.CategoryId == 0)
                {
                    await _db.Categories.AddAsync(obj);
                }
                else
                {
                    _db.Categories.Update(obj);
                }

                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            Category obj = new();
            obj = _db.Categories.FirstOrDefault(u => u.CategoryId == id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Categories.Remove(obj);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> CreateMultiple2()
        {
            for (int i = 0; i <= 1; i++)
            {
                _db.Categories.Add(new Category { CategoryName = $"My_Category {i}" });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> CreateMultiple5()
        {
            for (int i = 0; i <= 4; i++)
            {
                _db.Categories.Add(new Category { CategoryName = $"My_Category {i}" });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult RemoveMultiple2()
        {
            List<Category> categories = _db.Categories.OrderBy(u => u.CategoryId).ToList();

            for (int i = 0; i <= 1; i++)
            {
                _db.Categories.Remove(categories[i]);
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult RemoveMultiple5()
        {

            List<Category> categories = _db.Categories.OrderBy(u => u.CategoryId).ToList();

            for (int i = 0; i <= 4; i++)
            {
                _db.Categories.Remove(categories[i]);
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
