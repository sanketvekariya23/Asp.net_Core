using Microsoft.AspNetCore.Mvc;
using Sanket_web.Data;
using Sanket_web.Models;

namespace Sanket_web.Controllers
{
    public class CategoryController : Controller

    {   
        // CRUD - Read database


        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
                _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        // CRUD- Create

        public IActionResult Create()
        {   

            return View();  
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "category Created successfully.";
                return RedirectToAction("Index");
            }
            return Create();
        }

        // CRUD -update


        public IActionResult Edit(int? Id)
        {   if(Id==null || Id == 0)
            {
                return NotFound();
            }
            Category CategoryFromDb = _db.Categories.Find(Id);
            if(CategoryFromDb == null)
            {
                return NotFound();
            }
            return View(CategoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "category edited successfully.";
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        // crud - delete
        public IActionResult Delete(int? Id)
        {
            if(Id==null || Id == 0)
            {
                return NotFound();
            }
            Category CategoryFromDb = _db.Categories.Find(Id);
            if(CategoryFromDb == null)
            {
                return NotFound();
            }
            return View(CategoryFromDb);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePOST(int? Id)
        {
            Category CategoryFromDb = _db.Categories.Find(Id);
            _db.Categories.Remove(CategoryFromDb);
            _db.SaveChanges();
            TempData["success"] = "category Deleted successfully.";
            return RedirectToAction("Index");
        }
    }
}
