using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationFlower.Models;

namespace WebApplicationFlower.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> plist = new List<Product>();
            Product p1 = new Product() { Id = 1, Name = "Rose", Color = "Red", Price = 30 ,Image= "/images/rose.jpg" };
            Product p2 = new Product() { Id = 2, Name = "Marigold", Color = "Yellow", Price = 10, Image = "/images/orchid.jpg" };
            Product p3 = new Product() { Id = 3, Name = "SunFlower", Color = "Sunny", Price = 35 , Image = "/images/lotus.jpg" };
            Product p4 = new Product() { Id = 4, Name = "Jasmin", Color = "white", Price = 135, Image = "/images/jasmine.jpg" };
            
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);
            ViewBag.Products = plist;

            return View();
        }

        public ActionResult Orders()
        {
            ShopCart cart = this.Session["sc"] as ShopCart;
            ViewBag.orders = cart.GetAll();
            return View();
        }
    }
}