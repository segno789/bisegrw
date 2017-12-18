using BISEWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BISEWEB.Controllers
{
    public class HomeController : Controller
    {
        MiscDbEntities Miscdb = new MiscDbEntities();
        matric_newEntities matric_new = new matric_newEntities();
        Generics obj = new Generics();
        public ActionResult Index()
        {
            return View(obj.GetNodes());
        }

        public ActionResult About()
        {

            return View(obj.GetNodes());
        }
       
        public ActionResult Contact()
        {
            Session["ParentNodes"] = obj.GetNodes();

            List<tblParentNode> obbb = Session["ParentNodes"] as List<tblParentNode>;

            return View();
        }
        public void ClearSession()
        {
            Session["Redirect"] = "0";
        }
        public ActionResult def()
        {
            ViewBag.Message = "Your contact page.";

            return View(obj.GetNodes());
        }

        public ActionResult ghi()
        {

            return View(obj.GetNodes());

            //return View();
        }
    }
}