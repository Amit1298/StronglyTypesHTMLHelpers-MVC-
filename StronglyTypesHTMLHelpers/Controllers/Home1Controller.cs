using StronglyTypesHTMLHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypesHTMLHelpers.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        [HttpPost]
        public ActionResult Index(Calculation c)
        {
            int num1 = c.num1;
            int num2 = c.num2;
            int result = num1 + num2;
            ViewBag.result = result;
            return View();
        }
    }
}