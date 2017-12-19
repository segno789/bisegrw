using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BISEWEB.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
       
        public ActionResult SessionOut()
        {
            return View();
        }
    }
}