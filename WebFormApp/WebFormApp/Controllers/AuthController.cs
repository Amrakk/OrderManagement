using System.Net;
using System.Net.Mail;
using WebFormApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
                return Problem("Entity set 'OrderManagementContext.Users' is null.");

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

            if (user != null)
            {
                if (user.Password == password)
                {
                    var userId = user.UserId;
                    var url = $"{Request.Scheme}://{Request.Host}/Home/?id={userId}";

                    if(url == null)
                        return Problem("Url.Action() returned null.");

                    try { SendWorkplaceAccessEmail(user.Email, url); }
                    catch (Exception ex) { return Problem(ex.Message); }

                    ViewBag.ErrorMessage = "";
                    ViewBag.SuccessMessage = "Please check your email for workplace access instructions.";
                }
                else ViewBag.ErrorMessage = "Invalid Credentials";
            }
            else ViewBag.ErrorMessage = "Invalid Credentials";

            return View();
        }

        private void SendWorkplaceAccessEmail(string userEmail, string url)
        {
            SmtpClient emailService = new SmtpClient();
            emailService.Port = 587;
            emailService.Host = "smtp.gmail.com";
            emailService.EnableSsl = true;
            emailService.UseDefaultCredentials = false;
            emailService.Credentials = new NetworkCredential("amrakk.dev@gmail.com", "ndqblzebjdnomdku");
            emailService.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage message = new MailMessage();
            message.From = new MailAddress("amrakk.dev@gmail.com");
            message.To.Add(userEmail);
            message.Subject = "Workplace Access Link";
            message.IsBodyHtml = true;
            message.Body = $"Click the following link to access your workplace: <a href='{url}'>Access Workplace</a>";

            emailService.Send(message);
        }


    }
}
