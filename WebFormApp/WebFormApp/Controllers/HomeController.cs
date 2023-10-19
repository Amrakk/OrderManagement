using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebFormApp.Models;

namespace WebFormApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OrderManagementContext _context;

        public HomeController(ILogger<HomeController> logger, OrderManagementContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(string? id)
        {
            if (id == null) return RedirectToAction("Signin", "Auth");

            var user = _context.Users.Find(id);
            if (user == null) return RedirectToAction("Signin", "Auth");

            ViewBag.Email = user.Email;

            return View();
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