using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Anita.Models;
using EntityFramework.Extensions;

namespace Anita.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext dbContext = new AppDbContext();
        public ActionResult Index()
        {
            dbContext.UserInfo.Where(x=>x.UserName == "hahah").Delete();
            return View();
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