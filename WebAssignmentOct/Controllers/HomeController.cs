using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAssignmentOct.Models;

namespace WebAssignmentOct.Controllers
{
    public class HomeController : Controller
    {
        private List<Experience> experiences;

        public HomeController()
        {
            experiences = new List<Experience>();
            experiences.Add(new Experience() { education = "Digital Creation", period = "2014-2015" });
            experiences.Add(new Experience() { education = "Web development", period = "2014-2015" });
            experiences.Add(new Experience() { education = "Programming 1", period = "2015-2016" });
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(experiences);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}