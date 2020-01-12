using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoggleGame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetBoardData()
        {
            string charactes = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            List<char> charArray = charactes.ToCharArray().ToList();
            List<char> data = new List<char>();
            Random random = new Random();
            for (int i = 0; i < 16; i++)
            {
                int index = random.Next(0, 25);
                data.Add(charArray[index]);
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Boggle Game description.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}