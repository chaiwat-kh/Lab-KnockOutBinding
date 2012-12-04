using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SportService;

namespace EasyStart.Controllers
{
    public class HomeController : Controller
    {
        private ISportService _sportService = null;

        public HomeController()
        {
            _sportService = new SportService.SportService();
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SecondPage()
        {
            return View();
        }

        public ActionResult ScrollTo()
        {
            return View();
        }

        public ActionResult ThreePage()
        {
            return View();
        }

        public ActionResult EasyStart()
        {
            return View();
        }

        public ActionResult SimplePage()
        {
            return View();
        }

        public ActionResult GridPage()
        {
            return View();
        }

        public JsonResult GetData()
        {
            var news = _sportService.GetData();

            return Json(news, JsonRequestBehavior.AllowGet);
        }

    }
}
