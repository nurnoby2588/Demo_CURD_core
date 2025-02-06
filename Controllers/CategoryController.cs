using Microsoft.AspNetCore.Mvc;

namespace Demo_CURD_core.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
