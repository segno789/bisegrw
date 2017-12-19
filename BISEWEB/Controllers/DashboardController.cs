﻿using BISEWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BISEWEB.Controllers
{
    public class DashboardController : Controller
    {
        MiscDbEntities Miscdb = new MiscDbEntities();
        matric_newEntities matric_new = new matric_newEntities();
        Generics obj = new Generics();
        // GET: Dashboard
        public ActionResult Home()
        {
            Session["ParentNodes"] = obj.GetNodes();
            return View();
        }
    }
}