using Microsoft.AspNetCore.Mvc;
using TP1Asp.Data;
using TP1Asp.Models;
using Microsoft.EntityFrameworkCore;
using TP1Asp.Repositories;

namespace TP1Asp.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly IRepository<ToDoList> _toDoListRepository;

        public ToDoListController(IRepository<ToDoList> toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }

        public IActionResult Index()
        {
            return View(_toDoListRepository.GetAll());
        }

        public IActionResult AfficherFormulaireAjout()
        {
            return View("Add");
        }

        public IActionResult EnvoyerTache(ToDoList toDoList)
        {
            _toDoListRepository.Add(toDoList);

            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            var todo = _toDoListRepository.GetById(id);
            if (todo == null)
                return View("Error");
            _toDoListRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
