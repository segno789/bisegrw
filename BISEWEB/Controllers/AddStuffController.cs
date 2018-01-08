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
            ViewBag.tehsil = new SelectList(matric_new.tblTehsils.Where(o=>o.teh_cd<20), "teh_cd", "teh_name");
            //var tehsil = from p in matric_new.tblTehsils where p.teh_cd<20 select new {Tehsilname = p.teh_name,TehsilCode = p.teh_cd};
            //SelectList teh_list = new SelectList(tehsil, "TehsilCode", "Tehsilname");
            //ViewBag.tehsilsss = teh_list;

            ////var Izone = from p in matric_new.tblZones where p.Class  Convert.ToByte(12)  select new { ZoneName = p.zone_cd, TehsilCode = p.teh_cd };
            ////SelectList IZone_list = new SelectList(Izone, "TehsilCode", "Tehsilname");
            ////ViewBag.Izone = IZone_list;

            //var Mzone = from p in matric_new.tblTehsils select new { Tehsilname = p.teh_name, TehsilCode = p.teh_cd };
            //SelectList MZone_list = new SelectList(Mzone, "TehsilCode", "Tehsilname");
            //ViewBag.Izone = MZone_list;


            ViewBag.Izone = new SelectList(matric_new.tblZones.Where(o => o.mYear == DateTime.Now.Year && o.Class == 12), "zone_cd", "zone_name");

            ViewBag.Mzone = new SelectList(matric_new.tblZones.Where(o => o.mYear == DateTime.Now.Year && o.Class == 10), "zone_cd", "zone_name");


            var person = matric_new.tblTehsils
               .Join(matric_new.tblDistricts,
                     p => p.dist_cd,
                     e => e.dist_cd,

                     (p, e) => new {
                         teh_cd = p.teh_cd,
                         Dist_Name = e.dist_name
                          //MiddleName = p.MiddleName,
                          //LastName = p.LastName,
                          //EmailID = e.EmailAddress1
                      }
                     ).Where(c => c.teh_cd == 1)
                     .FirstOrDefault();

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



        [HttpGet]
        public ActionResult getdistricts()
        {
           int  teh = 1;

            var person = matric_new.tblTehsils
                .Join(matric_new.tblDistricts,
                      p => p.dist_cd,
                      e => e.dist_cd,

                      (p, e) => new {
                          teh_cd= p.teh_cd,
                          Dist_Name = e.dist_name
                          //MiddleName = p.MiddleName,
                          //LastName = p.LastName,
                          //EmailID = e.EmailAddress1
                      }
                      ).Where(c => c.teh_cd ==teh)
                      .FirstOrDefault();

            //var cities = matric_new.tblDistricts.Join(matric_new.tblTehsils.  .Where(c => c.dist_cd == teh);
            return Json(person, JsonRequestBehavior.AllowGet);
        }


        //public ActionResult GetZonesName(int zone_code )
        //{
        //    var zone_name = "";

        //    zone

        //    zone_name = matric_new.tblZones.Where(o => o.zone_cd = zone_code)    //Select(o => o.zone_name).Where(o => o);
        //    return Json(zone_name, JsonRequestBehavior.AllowGet);
        //}


        //public ActionResult GetCityList(string stateID)
        //{
        //    List<CITy> lstcity = new List<CITy>();
        //    int stateiD = Convert.ToInt32(stateID);
        //    using (CITYSTATEEntities cITYSTATEEntities = new CITYSTATEEntities())
        //    {
        //        lstcity = (cITYSTATEEntities.CITIES.Where(x => x.StateId == stateiD)).ToList<CITy>();
        //    }
        //    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
        //    string result = javaScriptSerializer.Serialize(lstcity);
        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}


    }




}