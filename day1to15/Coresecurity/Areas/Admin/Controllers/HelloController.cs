using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coresecurity.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult page1()
        {
            return View();
        }
        public IActionResult page2()
        {
            return View();
        }
    }
}
