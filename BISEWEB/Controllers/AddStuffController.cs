using BISEWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

<<<<<<< HEAD
namespace BISEWEB.Controllers
=======
namespace BISEWEB.Controllers.AddStuff
>>>>>>> 05115b3a94e6ee001a31abca420c2becd2129b86
{
    public class AddStuffController : Controller
    {
        MiscDbEntities Miscdb = new MiscDbEntities();
        matric_newEntities matric_new = new matric_newEntities();
        Generics obj = new Generics();
<<<<<<< HEAD

        // GET: AddStuff
        public ActionResult Index()
        {
            return View(obj.GetNodes());
    
        }

        public ActionResult AddNewInst()
        {
            return View(obj.GetNodes());
=======
        // GET: AddStuff
        public ActionResult AddEmployee()
        {
            List<tblParentNode> obbb = Session["ParentNodes"] as List<tblParentNode>;
            return View();
>>>>>>> 05115b3a94e6ee001a31abca420c2becd2129b86
        }
    }
}