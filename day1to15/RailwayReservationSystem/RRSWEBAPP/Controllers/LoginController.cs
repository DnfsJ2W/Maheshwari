using RRS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RRS_REPO;

namespace RRSWEBAPP.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogin abc;
        public LoginController(ILogin login)
        {
            this.abc = login;
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
      public ActionResult Index(Login model)
        {
        Login lg=    abc.vaildateUser(model.UserName, model.Password);
            if (lg == null)
            {
                ViewBag.errormessage = "Invalid";
                return View(model);
            }
            else
            {
                Session["username"] = model.UserName;
                return RedirectToAction("EmployeeHomePage");
            }
        }
        public ActionResult EmployeeHomePage()
        {
            return View();
        }
    }
}