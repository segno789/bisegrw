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

            var tehsil = from p in matric_new.tblTehsils where p.teh_cd<20 select new {Tehsilname = p.teh_name,TehsilCode = p.teh_cd};
            SelectList teh_list = new SelectList(tehsil, "TehsilCode", "Tehsilname");
            ViewBag.tehsil = teh_list;

            //var Izone = from p in matric_new.tblZones where p.Class  Convert.ToByte(12)  select new { ZoneName = p.zone_cd, TehsilCode = p.teh_cd };
            //SelectList IZone_list = new SelectList(Izone, "TehsilCode", "Tehsilname");
            //ViewBag.Izone = IZone_list;

            var Mzone = from p in matric_new.tblTehsils select new { Tehsilname = p.teh_name, TehsilCode = p.teh_cd };
            SelectList MZone_list = new SelectList(Mzone, "TehsilCode", "Tehsilname");
            ViewBag.Izone = MZone_list;


            return View();

        }
        [HttpPost]
        public ActionResult AddNewInst(tblbiodata vc)
        {
            //ViewBag.EventID = new SelectList(db.tblEvents, "EventID", "EventName");
            return View(vc);
        }



        // GET: AddStuff
        [HttpGet]
        public ActionResult AddEmployee()
        {
          
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddEmployee(tblemployee obj)
        {

            return View();

        }


    }

}