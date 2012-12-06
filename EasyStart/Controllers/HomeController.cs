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

        public ActionResult KnockOutGridPage()
        {
            return View();
        }

        public JsonResult GetGridData()
        {
            var news = _sportService.GetGridData();

            return Json(news, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetFullCol()
        {
            var news = _sportService.GetFullCol();

            return Json(news, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetHomePageData()
        {
            var news = _sportService.GetHomePageData();

            return Json(news, JsonRequestBehavior.AllowGet);
        }

    }
}
