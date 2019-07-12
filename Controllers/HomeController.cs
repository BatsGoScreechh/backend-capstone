using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MCTCTicketSystem2.Models;
using Microsoft.AspNetCore.Identity;

namespace MCTCTicketSystem2.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;

        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public async Task<IActionResult> Index()
        {
            var currentUser = await GetCurrentUserAsync();
            if(currentUser == null)
            {
                return View();
            }
            if (currentUser.isAdmin == false)
            {
                return View();
            }
            else if (currentUser.isAdmin == true)
            {
                return RedirectToAction("Index", "Admin");
            }
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
