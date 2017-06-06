using AddressAPI.Models;
using PHCNAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
//using System.Web.Mvc;

namespace PHCNAPI.Controllers
{

    public class AddressController : ApiController
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        [HttpGet]
        public IEnumerable<Customer> GetAllCustomer()
        {
            return _db.Customers.ToList();

        }

        [HttpGet]
        public HttpResponseMessage SearchByMeterNo(int meterno)
        {
            var customer = _db.Customers.FirstOrDefault(x => x.MeterNo == meterno);
            if (customer != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, customer);
            }
            else { 
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,"Customer with the MeterNo- "+ meterno.ToString() +" not found .");
            }
           




        }
      
    

        [HttpPost]
        // POST api/<controller>
        public HttpResponseMessage AddNewCustomer([FromBody] Customer customer)
        {
            try
            {
                _db.Customers.Add(customer);
                _db.SaveChanges();
                var message = Request.CreateResponse(HttpStatusCode.Created, customer);
                message.Headers.Location = new Uri(Request.RequestUri + customer.MeterNo.ToString());

                return message;
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
             
        }

        // [HttpPost]
        //public IHttpActionResult AddNewCustomer([FromBody] Customer customer)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _db.Customers.Add(customer);
        //    _db.SaveChanges();

        //    return Ok(customer);
        //}

        // PUT api/<controller>/5
        ////public void Put(int meterno, [FromBody]Customer cust)
        ////    {
        ////        var customer = _db.Customers.FirstOrDefault(c=>c.MeterNo== meterno)


        ////       customer.CustomerName = cust.CustomerName;
        ////        customer.AccountNo = cust.AccountNo;
        ////        emp.ContactNo = e.ContactNo;
        ////        emp.EMailID = e.EMailID;
        ////        emp.SkillSets = e.SkillSets;
        ////        _db.SaveChanges();
        ////        return GetAllCustomer();
        ////    }

        // DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
        //}

    }
}