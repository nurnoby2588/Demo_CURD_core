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
            
            _DbContext.Categories.Add(category);
            _DbContext.SaveChanges();
            return RedirectToAction("Index","Category"); 
        }
    }
}
