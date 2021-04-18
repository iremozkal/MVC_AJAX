using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_AJAX_INTRO.DATA.Model_Entity;

namespace MVC_AJAXINTRO.JQUERYAJAX.Controllers
{
    public class ProductController : Controller
    {
        private readonly NorthwindEntities DB;

        public ProductController()
        {
            DB = new NorthwindEntities();
        }

        public ActionResult Index()
        {
            return View(DB.Products.ToList());
        }

        public JsonResult GetProductDetail(int id)
        {
            Product productSelected = DB.Products.SingleOrDefault(p => p.ProductID == id);
            return Json(new
            {
                name = productSelected.ProductName,
                price = productSelected.UnitPrice,
                stockquantity = productSelected.UnitsInStock
            }, JsonRequestBehavior.AllowGet);
        }

    }
}
