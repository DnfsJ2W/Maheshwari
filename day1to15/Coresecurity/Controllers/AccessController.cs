using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coresecurity.Controllers
{
    public class AccessController : Controller
    {
        [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles ="Super Admin")]
        public IActionResult page1()
        {
            return View();
        }
    }
}
