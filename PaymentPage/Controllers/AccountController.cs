using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaymentPage.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentPage.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AccountController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Account()
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
