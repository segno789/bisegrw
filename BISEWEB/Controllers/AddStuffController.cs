using BISEWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BISEWEB.Controllers

{
    public class AddStuffController : Controller
    {
        MiscDbEntities Miscdb = new MiscDbEntities();
        matric_newEntities matric_new = new matric_newEntities();
        Generics obj = new Generics();


        // GET: AddStuff
        public ActionResult Index()
        {
            return View(obj.GetNodes());

        }
        [HttpGet]
        public ActionResult AddNewInst()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AddNewInst(tblbiodata vc)
        {
            //ViewBag.EventID = new SelectList(db.tblEvents, "EventID", "EventName");
            return View(vc);
        }



        // GET: AddStuff
        public ActionResult AddEmployee()
        {
          
            return View();

        }

       
    }

}