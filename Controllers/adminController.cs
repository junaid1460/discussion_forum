using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crook.Controllers
{
    public class adminController : Controller
    {
        //
        // GET: /admin/

        public ActionResult Index()
        {
            if ( Crook.MJCrook.isAdmin())
                return View();
            else
                return View("error");
        }
        public ActionResult nforum()
        {
            if (MJCrook.isAdmin())
                return View();
            else
                return View("");
        }
        public ActionResult edper()
        {
            if (MJCrook.isAdmin())
                return View();
            else
                return View("");
        }
        public ActionResult delete()
        {
            if (MJCrook.isAdmin())
                return View();
            else
                return View("");
        }
        public ActionResult addsub()
        {
            if (MJCrook.isAdmin())
                return View();
            else
                return View("");
        }
        public ActionResult error()
        {
            if (MJCrook.isAdmin())
                return View();
            else
                return View("");
        }
        

    }
}
