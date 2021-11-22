using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RantingService2.Models;

namespace RantingService2.Controllers
{
    public class HomeController : Controller
    {
        private CommentContext db = new CommentContext();
        //Get method
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Comments.Add(comment);
                db.SaveChanges();

                return RedirectToAction("CommentResult");

            }
            return View(comment);
        }
        public ActionResult CommentResult()
        {
            return View(db.Comments.ToList());
        }
    }
}
