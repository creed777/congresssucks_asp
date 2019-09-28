using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using congresssucks_asp.Models;

namespace congresssucks_asp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            IEnumerable<BlogPosts> Posts = _context.BlogPosts.Take(3).ToList();
            return View(Posts);
        }

        public ActionResult Article(int id)
        {
            var Article = _context.BlogPosts.Where(b => b.Id == id);
            return View(Article);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}