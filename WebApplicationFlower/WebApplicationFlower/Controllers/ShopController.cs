using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationFlower.Models;
namespace WebApplicationFlower.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Cart(int id)
        {
            SelectedProduct sp = new SelectedProduct() { Id = id,Quantity=0};
            ViewBag.SProd = sp;
            return View();
        }
        [HttpPost]
        public ActionResult Cart(int id,int quantity)
        {
            ShopCart cart=(ShopCart) this.Session["sc"];

            cart.AddProduct(id, quantity);
            return RedirectToAction("Orders", "Product");
        }
    }
}