using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace New_Project.Controllers
{
    public class PublisherController : Controller
    {
        private readonly ApplicationDBContext _db;

        public PublisherController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Publisher_Index()
        {
            List<Publisher> obj = _db.Publishers.ToList();
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            Publisher obj = _db.Publishers.FirstOrDefault(u => u.Publisher_Id == id);
            _db.Publishers.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Publisher_Index");
        }

        public IActionResult Edit(int? id)
        {
            Publisher obj = _db.Publishers.FirstOrDefault(u => u.Publisher_Id == id);

            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Publisher obj)
        {

            _db.Publishers.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Publisher_Index");
        }

        public IActionResult Create()
        {
            Publisher obj = new Publisher();
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Publisher obj)
        {
            _db.Publishers.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Publisher_Index");
        }
    }
}
