using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockout.Mvc.Integration.Web.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PostJson(FormCollection form)
        {
            ViewBag.Example1Message = string.Format(
                "Submitted FormCollection as firstName: {0}; lastName: {1}; username: {2};",
                form["firstName"],
                form["lastName"],
                form["username"]);

            return View("Index");
        }
    }
}
