using AnimalsMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsMVC.Controllers
{
    public class AnimalController : Controller
    {

        private readonly IAnimalRepo _repo;

        public AnimalController(IAnimalRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var animals = _repo.GetAllAnimals();
            return View(animals);
        }
    }
}
