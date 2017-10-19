using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crook.Controllers
{
    public class tutorialsController : Controller
    {
        //
        // GET: /tutorials/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult css(object id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult c(object id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult java(object id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult javascript(object id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult xml(object id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult xslt(object id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult cpp(object id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult csharp(object id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult html(object id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
