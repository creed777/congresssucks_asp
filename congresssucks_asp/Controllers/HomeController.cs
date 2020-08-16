using congresssucks_asp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

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
            IEnumerable<BlogPosts> Posts = _context.BlogPosts.Take(4).OrderByDescending(b=>b.Updated).ToList();
            return View(Posts);
        }

        public ActionResult Resources()
        {
            IEnumerable<Resources> resources = _context.Resources;
            return View(resources);
        }

        public ActionResult Article(int id)
        {
            if (id == 0)
            {
                return HttpNotFound();
            }
            else
            {
                var Article = _context.BlogPosts.Where(b => b.Id == id).FirstOrDefault();
                return View(Article);
            }    
            
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