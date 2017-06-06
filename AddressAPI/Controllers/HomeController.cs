using AddressAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressAPI.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult ListRecords()
        {
            var customers = _db.Customers.ToList();
            ViewBag.Title = "List Records";

            return View(customers);
        }

        
    }
}
