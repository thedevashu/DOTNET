using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Movies()
        {
            List<Movie> mlist = MovieList.GetAll();
            ViewBag.MLlist = mlist;
            return View();
        }
    }
}