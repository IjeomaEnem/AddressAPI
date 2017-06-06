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
            ViewBag.Title = "Search Page";

            return View();
        }
        //public ActionResult GetCustomer(int meterno)
        //{
        //    var customer = _db.Customers.FirstOrDefault(m => m.MeterNo == meterno);
        //    ViewBag.Title = "Customer Search Result";
            
        //    return View(customer);
        //}
        //public ActionResult ListRecords()
        //{
        //    var customers = _db.Customers.ToList();
        //    ViewBag.Title = "List Records";

        //    return View(customers);
        //}

        
    }
}
