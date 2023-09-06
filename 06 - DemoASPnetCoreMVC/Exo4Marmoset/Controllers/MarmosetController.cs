using Exo4Marmoset.Data;
using Exo4Marmoset.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exo4Marmoset.Controllers
{
    public class MarmosetController : Controller
    {
        private readonly FakeMarmosetDb _fakeMarmosetDb;
        private readonly ApplicationDbContext _dbContext;

        public MarmosetController(/*FakeMarmosetDb fakeMarmosetDb,*/ ApplicationDbContext dbContext)
        {
            //_fakeMarmosetDb = fakeMarmosetDb;
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            //return View(_fakeMarmosetDb.GetAll());
            return View(_dbContext.Marmosets.ToList());
        }

        public IActionResult Details(int id)
        {
            //return View(_fakeMarmosetDb.GetById(id));
            return View(_dbContext.Marmosets.Find(id));
        }

        public IActionResult CreateRandomMonkey(Marmoset marmoset)
        {
            marmoset = new Marmoset
            {
                Name = RandomString("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 6),
                Age = new Random().Next(1, 100)
            };

            //_fakeMarmosetDb.Add(monkey);
            _dbContext.Marmosets.Add(marmoset);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteMarmoset(Marmoset marmoset)
        {
            var marmosetToRemove = _dbContext.Marmosets.Find(marmoset.Id);
            if (marmosetToRemove == null)
                return NotFound();
            _dbContext.Marmosets.Remove(marmosetToRemove);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
            
        }

        [NonAction]
        public string RandomString(string chars, int length)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
