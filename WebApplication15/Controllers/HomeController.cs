using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
        public IActionResult Index()
        {
            return View(Database.GetList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Persona p)
        {
            Database.AddPerson(p);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var p = Database.GetPerson(id);
            return View(p);
        }

        [HttpPost]
        public IActionResult Edit(Persona p)
        {
            Database.Replace(p);
            return RedirectToAction("Index");
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