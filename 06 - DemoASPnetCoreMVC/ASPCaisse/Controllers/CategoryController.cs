using Microsoft.AspNetCore.Mvc;

namespace TPASPCaisse.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
