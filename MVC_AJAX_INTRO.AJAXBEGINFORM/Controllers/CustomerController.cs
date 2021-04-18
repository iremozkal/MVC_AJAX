using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_AJAX_INTRO.DATA.Model_Entity;

namespace MVC_AJAX_INTRO.AJAXBEGINFORM.Controllers
{
    public class CustomerController : Controller
    {
        private readonly NorthwindEntities DB;

        public CustomerController()
        {
            DB = new NorthwindEntities();
        }

        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string CustomerControl(string CustomerID)
        {
            Customer customerSelected = DB.Customers.FirstOrDefault(c => c.CustomerID == CustomerID);

            if (customerSelected == null)
            {
                return "There is no such a customer!";
            }
            else
            {
                return "Welcome " + customerSelected.ContactName + "!";
            }
        }
    }
}
