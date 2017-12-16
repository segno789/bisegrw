using BISEWEB.Models;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BISEWEB.Controllers
{
    public class UserController : Controller
    {
        MiscDbEntities Miscdb = new MiscDbEntities();
        matric_newEntities matric_new = new matric_newEntities();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UserLogin()
        {
            Session["UserID"] = null;
            Session["UserName"] = null;
            Session.Abandon();
            Session.Clear();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserLogin(tblemployee objUser)
        {
            if (ModelState.IsValid)
            {
                tblemployee obj = Miscdb.tblemployees.Where(a => a.emp_cd.Equals(objUser.emp_cd) && a.pass.Equals(objUser.pass)).FirstOrDefault();
                if (obj != null)
                {
                    int emp = Convert.ToInt32(obj.emp_cd);

                    BE.User obj_user = new BE.User();
                    obj_user.Emp_cd = emp;
                    obj_user.IsSuperAdmin = Convert.ToBoolean(obj.isSuperAdmin);
                    obj_user.Name = obj.Name;
                    obj_user.Branch_Code = Convert.ToInt32(obj.Branch_Code);


                    SessionWrapper.User = obj_user;

                    Session["Redirect"] = "1";
                    return RedirectToAction("Contact", "Home");
                }

            }

            return View(objUser);
        }
    }
}