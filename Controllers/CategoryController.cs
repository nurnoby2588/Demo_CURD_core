using Demo_CURD_core.Data;
using Demo_CURD_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_CURD_core.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _DbContext;
        public CategoryController(ApplicationDBContext DBContext)
        {
                 _DbContext = DBContext;
        }
        public IActionResult Index()
        {
            List<Category> categories = _DbContext.Categories.ToList();
            return View(categories);
        }

        public IActionResult CreateCategory() { 
        return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {

            if (ModelState.IsValid) {
                _DbContext.Categories.Add(category);
                _DbContext.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
        // edit/updat
        public IActionResult EditCategory(int? CategoryID)
        {
            if (CategoryID == 0 || CategoryID == null) { return NotFound(); }
            // CatergoryContoller all value in _DBContext
            Category? category = _DbContext.Categories.Find(CategoryID);
            // another way find .collum ar jei value r first a match korbe oi value niye asbe.
            Category? category1 = _DbContext.Categories.FirstOrDefault(c=>c.CategoryID == CategoryID);
            if (category1 == null) { return NotFound(); }
            return View(category);
        }
        [HttpPost]
        public IActionResult EditCategory(Category category)
        {

            if (ModelState.IsValid)
            {
                _DbContext.Categories.Update(category);
                _DbContext.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
    }
}
