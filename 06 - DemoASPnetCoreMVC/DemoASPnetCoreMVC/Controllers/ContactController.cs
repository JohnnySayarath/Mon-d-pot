using DemoASPnetCoreMVC.Data;
using DemoASPnetCoreMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace DemoASPnetCoreMVC.Controllers
{
    public class ContactController : Controller
    {
        private FakeContactDb _fakeContactDb;
        public ContactController(FakeContactDb fakeContactDb)
        {
            _fakeContactDb = fakeContactDb;
        }
        public IActionResult Index()
        {
            //return "Je suis la page pour afficher les contacts...";

            //var contactList = new List<Contact>()
            //{
            //    new Contact { Id = 1, FirstName = "Bob", LastName="Marley", Email="bobo@ganjamail.com", Phone="0607080910"},
            //    new Contact { Id = 2, FirstName = "Elvis", LastName="Presley", Email="elvis@rock.com", Phone="0607080911"},
            //    new Contact { Id = 3, FirstName = "Michael", LastName="Jackson", Email="mj@popking.com", Phone="0607080912"},
            //};

            //ViewData["contacts"] = contactList;

            //ViewBag.Contacts = contactList;

            _fakeContactDb.Add(new Contact() { Id = 4, FirstName = "nouveau" });

            return View(_fakeContactDb.GetAll());
        }

        public IActionResult Details(int id)
        {
            //return $"Je suis la page pour afficher le contact n°{id} en détail...";
            //Contact contact = new Contact { Id = 1, FirstName = "Bob", LastName = "Marley", Email = "bobo@ganjamail.com", Phone = "0607080910" };

            //ViewData["contact"] = contact;
            //ViewBag.Contact = contact;

            var contact = _fakeContactDb.GetById(id);

            return View(contact);
        }

        public IActionResult Add()
        {
            //return "Je suis la page pour ajouter un contact...";
            return View();
        }

    }
}
