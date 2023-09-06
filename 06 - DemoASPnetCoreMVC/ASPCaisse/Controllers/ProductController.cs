using Microsoft.AspNetCore.Mvc;
using TPASPCaisse.Repositories;
using TPASPCaisse.Models;

namespace TPASPCaisse.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
