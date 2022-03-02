using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductWebApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> list = this.HttpContext.Application["pList"] as List<Product>;
            return View(list);
        }
        public ActionResult Add()
        {
            Product p = new Product();
            return View(p);
        }
        [HttpPost]
        public ActionResult Add(Product p)
        {
            ProductDAO.Insert(p);
            List<Product> pl = (List<Product>)this.HttpContext.Application["pList"];
            pl.Add(p);
            return RedirectToAction("Index","Product");
        }
    }
}