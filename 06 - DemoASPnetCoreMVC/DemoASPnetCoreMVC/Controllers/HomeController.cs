using DemoASPnetCoreMVC.Data;
using DemoASPnetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoASPnetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly FakeContactDb _fakeContactDb;

        public HomeController(FakeContactDb fakeContactDb)
        {
            _fakeContactDb = fakeContactDb;
        }
        public string GetContacts() // /Home/GetContacts
        {
            string nomContacts = "";
            foreach (var c in _fakeContactDb.GetAll())
            {
                nomContacts += c.FirstName + "";
            }
            return nomContacts;
        }

        public IActionResult Index()
        {
            var maListe = new List<string>()
            {
                "chaine1",
                "chaine2",
                "chaine3",
            };

            // passer des données à la vue

            // méthode 1: ViewData
            ViewData["MaListe"] = maListe;

            // méthode 2: ViewBag
            ViewBag.MaListe = maListe;

            // méthode 3: Model

            return View(maListe);


            //Marmoset ouist = new Marmoset()
            //{
            //    Id = 1,
            //    Name = "Babouche",
            //    Age = 6
            //};

            //return View(ouist);
        }

        public IActionResult Index2()
        {
            var maListe = new List<string>()
            {
                "Ici c'est Index 2",
                "Ici c'est Index 2",
            };

            ViewData["MaListe"] = maListe;

            return View("Index"); // retourne directement la view Index.cshtml
        }

        public IActionResult Index3()
        {
            //return RedirectToAction("Index"); // on repasse par l'action "Index" (/Home/Index)
            return RedirectToAction(nameof(Index)); 
        }

        // /Home/DitBonjour
        public string DitBonjour()
        {
            return "Bonjour à toi !";
        }

        // Home/DitBonjourA?personne=Guillaume
        public string DitBonjourA(string personne)
        {
            return $"Bonjour à toi {personne}!";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}