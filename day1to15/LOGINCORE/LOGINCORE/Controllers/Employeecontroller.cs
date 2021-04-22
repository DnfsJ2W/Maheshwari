using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGINCORE.Controllers
{
    public class Employeecontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
