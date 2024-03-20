using Microsoft.AspNetCore.Mvc;

namespace Week3.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
