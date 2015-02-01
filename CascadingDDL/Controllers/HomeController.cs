using CascadingDDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingDDL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ManufacturerList()
        {
            var manufacturers = Manufacturer.GetManufacturers();

            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(manufacturers.ToArray(), "ManCode", "ManName"), JsonRequestBehavior.AllowGet);
            }

            return RedirectToAction("Index");
        }

        public ActionResult CategoryList(string ID)
        {
            var categories = from c in Category.GetCategories()
                             where c.ManCode == ID
                             select c;
            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(categories.ToArray(),"CategoryID","CategoryName"),
                    JsonRequestBehavior.AllowGet);
            }

            return RedirectToAction("Index");
        }

        public PartialViewResult GetLaptops(string category)
        {
            var laptops = (from l in Laptop.GetProducts()
                           where l.Category == category
                           select l).AsEnumerable();
            return PartialView(laptops);
        }
    }
}
