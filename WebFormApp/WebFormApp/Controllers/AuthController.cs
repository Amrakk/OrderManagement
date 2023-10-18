using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using WebFormApp.Models;

namespace WebFormApp.Controllers
{
    public class AuthController : Controller
    {

        private readonly OrderManagementContext _context;

        public AuthController(OrderManagementContext context)
        {
            _context = context;
        }

        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signin(string email, string password)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'OrderManagementContext.Users'  is null.");
            }
            foreach(User u in _context.Users)
            {
                   Console.WriteLine(u.Email);
            }
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

            if (user != null)
            {
                if (user.Password == password)
                {
                    // create a jwt tokenID and create a URL to redirect to
                    // string tokenID
                    // string redirectURL = "https://localhost:5001/Orders?tokenID=" + tokenID;

                    var tokenID = Guid.NewGuid().ToString();

                    // redirect to Home/Index with tokenID
                    return RedirectToAction("Index", "Home", new { id = tokenID });
                }
                return Unauthorized("Invalid password");
            }
            return Unauthorized("Invalid email");
        }

    }
}
