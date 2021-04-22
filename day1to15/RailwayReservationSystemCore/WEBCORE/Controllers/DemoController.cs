using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RRBCORE.Models;
using RRBCore_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCORE.Controllers
{
    public class DemoController : Controller
    {
        private readonly ILogin _models;
       

        public DemoController(ILogin model)
        {
            this._models = model;

        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Login model)
        {
            Login lg = _models.validateuser(model.UserName, model.Password);
           
            if (lg == null)
            {
                ViewBag.ErrorMessage = "Invaild User name and password";
                return View(model);
            }
            else
            {
                HttpContext.Session.SetString("username", model.UserName);
               // Session["username"] = model.UserName;
                return RedirectToAction("EmployeeHomePage");
            }


        }
        public ActionResult EmployeeHomePage()
        {
            return View();
        }

    }
}
