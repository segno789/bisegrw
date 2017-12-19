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

        public ActionResult AddNewInst()
        {
            return View();

        }

        

        // GET: AddStuff
        public ActionResult AddEmployee()
        {
          
            return View();

        }

       
    }

}