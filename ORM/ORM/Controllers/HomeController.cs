using ORM.DAO;
using ORM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ORM.Controllers
{
    public class HomeController : Controller
    {
        DbOrmContext entity = new DbOrmContext();
        // GET: Hoem
        public ActionResult Index()
        {
            DbSet<Product> l=entity.products;
            
            List<Product> lst =l.ToList<Product>();
          
            return View(lst);
        }
       

        public ActionResult Info(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            var p = entity.products.SingleOrDefault(prod => prod.Id == id);

            return View(p);
        }
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var p = entity.products.SingleOrDefault(prod => prod.Id == id);
            ViewBag.prod = p;
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            entity.Entry(p).State = EntityState.Modified;
            entity.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var p = entity.products.SingleOrDefault(pro => pro.Id == id);
            entity.products.Remove(p);
            entity.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Add()
        {
            Product p = new Product();
            return View(p);
        }

       [HttpPost]
        public ActionResult Add(Product p)
        {
            entity.products.Add(p);
            entity.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}