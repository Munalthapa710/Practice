using Bulkyweb.Data;
using Bulkyweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bulkyweb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList(); //retrive data
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (!string.IsNullOrEmpty(obj.Name) &&
                !string.IsNullOrEmpty(obj.DisplayOrder) &&
                obj.Name == obj.DisplayOrder)
            {
                ModelState.AddModelError("Name", "The display order cannot be exactly same as name.");
            }

            if (!string.IsNullOrEmpty(obj.Name) &&
                obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Test is invalid value.");
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}