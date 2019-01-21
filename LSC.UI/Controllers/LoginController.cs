using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzCore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            string username = HttpContext.User.Identity.Name;
            return View();
        }
    }
}