using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinLoans.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinLoans.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("SignIn");
            }
        }

        public async Task<IActionResult> Secure()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Loan()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult ApplyLoan()
        {
            return View();
        }

        public IActionResult Element()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult Contact()
        {
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

        public IActionResult Logout()
        {
            return new SignOutResult(new[] { "Cookies", "oidc" });
        }
    }
}
