using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using MVC.Models;

// Jquery to submit data and validation
// Jquery to Display data

namespace MVC.Controllers
{
    [Route("MyClass")]
    public class AttributeController : Controller
    {
        [Route("MyMethod")]
        public ActionResult Attrib1()
        {
            return View("GetData");
        }
    }
    public class HomeController : Controller
    {
        public ActionResult GetData(int? Name)
        {

            return View();
        }

        // To read data from View
        public ActionResult FormCollectionsSample(FormCollection collection)
        {
            return View();
        }

        public ActionResult StronglyType()
        {
            List<Customer> obCust = new List<Customer>();
            obCust.Add(new Customer() { Name = "Rohith", Age = 7 });
            obCust.Add(new Customer() { Name = "Senthil", Age = 35 });
            return View(obCust);
        }

        public ActionResult PassData()
        {
            TempData["Name"] = "Rohith";
            ViewData["Name"] = "Senthil";
            ViewBag.Name = "Senthil";

            TempData["Persist"] = "Persist";

            TempData["NotRead"] = "NotRead";

            TempData["Keep"] = "Keep";

            return View();
        }
    }
}
