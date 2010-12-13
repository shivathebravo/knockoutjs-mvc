using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Knockout.Mvc.Integration.Web.Resources;
using Knockout.Mvc.Integration.Web.Utils;

namespace Knockout.Mvc.Integration.Web.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PostJson1(FormCollection form)
        {
            ViewBag.Example1Message = string.Format(
                Strings.FormSubmissionMessage,
                form["firstName"],
                form["lastName"],
                form["username"]);

            return View("Index");
        }

        public ActionResult PostJson2(Model.UserDetails form)
        {
            ViewBag.Example2Message = string.Format(
                Strings.FormSubmissionMessage,
                form.FirstName,
                form.LastName,
                form.Username);

            return View("Index");
        }

        
        public ActionResult PostJson3(Model.UserDetailsEx form)
        {
            ViewBag.Example3Message = string.Format(
                Strings.FormSubmissionMessageEx,
                form.FirstName,
                form.LastName,
                form.Username,
                form.Skills.Count);

            return View("Index");
        }

        public ActionResult PostJson4(
            [ModelBinder(typeof(UserDetailsExCustomBinder))]
            Model.UserDetailsEx form)
        {
            ViewBag.Example4Message = string.Format(
                Strings.FormSubmissionMessageEx,
                form.FirstName,
                form.LastName,
                form.Username,
                form.Skills.Count);

            return View("Index");
        }

        public ActionResult SimpleAjax(Model.UserDetailsEx form)
        {
            string message = string.Format(
                Strings.FormSubmissionMessageEx,
                form.FirstName,
                form.LastName,
                form.Username,
                form.Skills.Count);

            return Json(message);
        }
    }
}
