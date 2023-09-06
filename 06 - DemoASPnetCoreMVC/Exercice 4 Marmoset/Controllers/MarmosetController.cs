using Exercice_4_Marmoset.Data;
using Microsoft.AspNetCore.Mvc;

namespace Exercice_4_Marmoset.Controllers
{
    public class MarmosetController : Controller
    {
        private FakeMarmosetDb _fakeMarmosetDb;
        public MarmosetController(FakeMarmosetDb fakeMarmosetDb)
        {
            _fakeMarmosetDb = fakeMarmosetDb;
        }
        public IActionResult Index()
        {
   
            return View(_fakeMarmosetDb.GetAll());
        }

        public IActionResult Details(int id)
        {
            
            var marmoset = _fakeMarmosetDb.GetById(id);

            return View(marmoset);
        }

        public IActionResult Add()
        {
            //return "Je suis la page pour ajouter un contact...";
            return View();
        }
    }
}
