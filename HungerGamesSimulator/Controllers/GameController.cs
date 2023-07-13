using Microsoft.AspNetCore.Mvc;

namespace HungerGamesSimulator.NewFolder
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
