using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_AJAX_INTRO.DATA.Model_Entity;

namespace MVC_AJAXINTRO_JQUERYAJAX2.Controllers
{
    public class CustomerController : Controller
    {
        private readonly NorthwindEntities DB;

        public CustomerController()
        {
            DB = new NorthwindEntities();
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllCustomer()
        {
            return Json(DB.Customers.ToList().Select(x => new { name = x.ContactName }), JsonRequestBehavior.AllowGet);
        }
    }
}
