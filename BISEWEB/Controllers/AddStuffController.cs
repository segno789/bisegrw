using BISEWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BISEWEB.Controllers.AddStuff
{
    public class AddStuffController : Controller
    {
        MiscDbEntities Miscdb = new MiscDbEntities();
        matric_newEntities matric_new = new matric_newEntities();
        Generics obj = new Generics();
        // GET: AddStuff
        public ActionResult AddEmployee()
        {
            List<tblParentNode> obbb = Session["ParentNodes"] as List<tblParentNode>;
            return View();
        }
    }
}