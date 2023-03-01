using DAL_vippro2;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BO_SHOP_NTQ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBConnection db_shop = new DBConnection();
            return View(db_shop.Users);
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