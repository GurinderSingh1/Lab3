using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplicaion.Models;

namespace PhoneApplicaion.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {

            var phoneList = new List<Phone>
   {
   new Phone { phoneId = 1,phoneName = "Samsung",manufacturer = "Samsung",
       msrp = 1299.99,Screensize = 5.6,DateReleased =DateTime.Parse("09-06-2019") }


   };
            return View(phoneList);
           
        }
    }
}