using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;
using WebMatrix.Data;
using Crook;

namespace Crook.Controllers
{
    public class forumController : Controller
    {
        //
        // GET: /forum/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult show(object id)
        {
            var c = Convert.ToString(id);
            if (c == "System.Object")
            {
                return Redirect("~/error");
            }
            ViewBag.forum = id;
            return View();
        }
        public ActionResult addpost(object id)
        {
            var c = Convert.ToString(id);
            if (c == "System.Object")
            {
                return Redirect("~/error");
            }
            ViewBag.param = id;
            return View();
        }
        public ActionResult error()
        {
                return View();
        }
        public ActionResult showpost(object id)
        {
            var c = Convert.ToString(id);
            if (c == "System.Object")
            {
              return  Redirect("~/error");
            }
            ViewBag.post=id;
            return View();
        }
        public ActionResult list(object id)
        {
            var c = Convert.ToString(id);
            if (c == "System.Object")
            {
                return Redirect("~/error");
            }
            ViewBag.post = c;
            return View();
        }
        public ActionResult reply(object id)
        {
            var c = Convert.ToString(id);
            if (c == "System.Object")
            {
                return Redirect("~/error");
            }
            ViewBag.param = c;

            if (!WebSecurity.IsAuthenticated)
            {
                return Redirect("~/Account/login");
            }
            // ***/addpost/forum_id-type
            var frm = ViewBag.param;
            var forum = "";
            var type = "";
            var rpost = "";
            var pby = "";
            try
            {
                var frmtp = (Convert.ToString(frm) + "").Split('-');
                forum = frmtp[0];
                type = frmtp[1];
                rpost = frmtp[2];
                pby = frmtp[3];
            }
            catch (Exception e)
            {
                Crook.tools.log("reply/Action", e.Message, "paramsplit", "redirectToErrorPage");
                return Redirect("~/error?" + frm + "&" + e.Message);

            }
            var cc = type == null ? 0 : Convert.ToUInt32(type);
            int xx = (int)cc;
            switch (xx)
            {
                case 1:
                    type = "general";
                    break;

                case 2:
                    type = "QA";
                    break;

                case 3:
                    type = "thirddev";
                    break;

                case 4:
                    type = "origdev";
                    break;

                case 5:
                    type = "projects";
                    break;

                default:
                    Response.Redirect("~/error?" + c);
                    break;
            }
            var post = Request.Unvalidated.Form["post"];
            var db = Database.Open("defaultconnection");
            var q = "INSERT INTO replies([RPOST] ,[post] ,[RBY] ,[isQuo],[quoPostRID] ,[time],[likes],[RPOSTTYPE],[Forum]) VALUES('"+rpost+"','"+post+"','"+WebSecurity.CurrentUserId+"','0','n/a','"+DateTime.Now+"','0','"+cc+"','"+forum+"')";
            try
            {
                db.Query(q);
            }
            catch (Exception e) {
                Crook.tools.log("reply/Action", e.Message, "queryExec", "redirectToErrorPage");
                return Redirect("~/error?ugyhgh");
                
            }
            var qc = "SELECT COUNT(*) FROM replies WHERE [RPOST]='" + rpost + "' and [RPOSTTYPE]='" + cc + "'";
            int totrep = Convert.ToInt32(db.QueryValue(qc));
            var pages = (totrep / 10) + 1;
            if (pages > 1)
            {
                return Redirect("~/forum/replies/"+forum+"-"+rpost+"-"+cc+"-"+pages);
            }
            else
            {
                return Redirect("~/forum/showpost/" + forum + "-" + rpost + "-" + cc);
            }
        }

        public ActionResult replies(object id)
        {
            var c = Convert.ToString(id);
            if (c == "System.Object")
            {
                return Redirect("~/error");
            }
            ViewBag.param = c;
            return View();
        }
        public ActionResult redirectpage(object id)
        {
            var c = Convert.ToString(id);
            if (c == "System.Object")
            {
                return Redirect("~/error");
            }
            ViewBag.param = c;

            if (!WebSecurity.IsAuthenticated)
            {
                return Redirect("~/Account/login");
            }
            // ***/addpost/forum_id-type
            var frm = ViewBag.param;
            var forum = "";
            var type = "";
            var rpost = "";
            var page = Request["page"];
            try
            {
                var frmtp = (Convert.ToString(frm) + "").Split('-');
                forum = frmtp[0];
                type = frmtp[1];
                rpost = frmtp[2];
            }
            catch (Exception e) {
                Crook.tools.log("redirectrep", e.Message, "param conversion", "redirect to error");
                return Redirect("~/error");
            }
            if (page == "1") {
                return Redirect("~/forum/showpost/" + forum + "-" + type + "-" + rpost );
            }
            else
            {
                return Redirect("~/forum/replies/" + forum + "-" + type + "-" + rpost + "-" + page);
            }
        }
        public ActionResult like(object id)
        {
           
            var c = Convert.ToString(id);
            if (c == "System.Object")
            {
                return Redirect("~/error");
            }
            ViewBag.param = c;

            if (!WebSecurity.IsAuthenticated)
            {
               return Redirect("~/Account/login");
            }
            // ***/addpost/forum_id-type
            var frm = ViewBag.param;
            var LKType = "";
            var pid = "";
            var Liker = WebSecurity.CurrentUserId;
            var re = Request["r"];
            var forum = "";
            var type = "";
            var who = "";
            try
            {
                var frmtp = (Convert.ToString(frm) + "").Split('-');
                LKType = frmtp[0];
                pid = frmtp[1];
                forum = frmtp[2];
                type = frmtp[3];
                who = frmtp[4];
            }
            catch (Exception e)
            {
                Crook.tools.log("like", e.Message, "param conversion", "redirect to error");
                return Redirect("~/error");
            }
            var db = Database.Open("defaultconnection");
            var q = "INSERT INTO Likes([LKType],[PID],[Liker],[forumID],[Ftype],[WHO]) VALUES('"+LKType+"','"+pid+"','"+WebSecurity.CurrentUserId+"','"+forum+"','"+type+"','"+who+"')";
            db.Query(q);
            return Redirect("~/forum/" + re);
        }
        public ActionResult unlike(object id)
        {

            var c = Convert.ToString(id);
            if (c == "System.Object")
            {
                return Redirect("~/error");
            }
            ViewBag.param = c;

            if (!WebSecurity.IsAuthenticated)
            {
                return Redirect("~/Account/login");
            }
            // ***/addpost/forum_id-type
            var frm = ViewBag.param;
            var LKType = "";
            var pid = "";
            var Liker = WebSecurity.CurrentUserId;
            var re = Request["r"];
            var forum = "";
            var type = "";
            try
            {
                var frmtp = (Convert.ToString(frm) + "").Split('-');
                LKType = frmtp[0];
                pid = frmtp[1];
                forum = frmtp[2];
                type = frmtp[3];
            }
            catch (Exception e)
            {
                Crook.tools.log("like", e.Message, "param conversion", "redirect to error");
                return Redirect("~/error");
            }
            var db = Database.Open("defaultconnection");
            var q = "DELETE  FROM Likes where [Liker]='"+WebSecurity.CurrentUserId+"' and [forumID]='"+forum+"' and [Ftype]='"+type+"' and [PID]='"+pid+"'";
            db.Query(q);
            return Redirect("~/forum/" + re);
        }
       
        public ActionResult editreply(object id) {
            var c = Convert.ToString(id);
            if (c == "System.Object")
            {
                return Redirect("~/error");
            }
            ViewBag.param = c;

            if (!WebSecurity.IsAuthenticated)
            {
                return Redirect("~/Account/login?returnURL=/forum/editreply/" + Convert.ToString(id));
            
            }
           
               ViewBag.rid = c;
               ViewBag.returnURL = Request["r"];
               
            return View();
        }
        public ActionResult editpost(object id)
        {
            var c = Convert.ToString(id);
            if (c == "System.Object")
            {
                return Redirect("~/error");
            }
            ViewBag.param = c;

            if (!WebSecurity.IsAuthenticated)
            {
                return Redirect("~/Account/login?returnURL=/forum/editpost/" + Convert.ToString(id));

            }
            var frmtp = (Convert.ToString(c) + "").Split('-');
            var Type = frmtp[0];
            var pid = frmtp[1];
            ViewBag.type = Type;
            ViewBag.pid = pid;
            ViewBag.returnURL = Request["r"];
            return View();
        }

    }


}
namespace Crook {


    public class MJCrook
    {
        public static Boolean isAdmin()
        {
            if (WebMatrix.WebData.WebSecurity.CurrentUserName == "junaid1460@gmail.com")
                return true;
            else
                return false;
        }
       
    }
    public class tools
    {
       
        
        public static void log(string file, string errormsg, string operation, string action)
        {
            var db = Database.Open("defaultconnection");
            var qq = "INSERT INTO logs([file],[msg],[work],[action]) VALUES('" + file + "','" + errormsg + "','" + operation + "','" + action + "')";
            db.Query(qq);
            db.Close();
        }
    }
}

