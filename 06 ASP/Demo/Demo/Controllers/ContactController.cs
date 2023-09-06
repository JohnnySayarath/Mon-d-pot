using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            Contact contactList = new Contact
            {
                Id = 1,
                Nom = "Sayarath",
                Prenom = "Johnny",
                Email = "Johnny@hotmail.fr",
                Telephone = "0606060805"
            };
            List<Contact> contacts = new List<Contact>
            {
                contactList
            };
            ViewBag.Contacts = contactList;
            return View(contactList);
        }

        public IActionResult Details(int id)
        {

            return View();
        }
    }
}
