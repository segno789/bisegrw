using BISEWEB.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace BISEWEB.Controllers
{
    public class MyWebAPIController : ApiController
    {
        MiscDbEntities Miscdb = new MiscDbEntities();
        matric_newEntities matric_new = new matric_newEntities();

        //[ActionName("GetNameByID")]
        [HttpPost]
        public string GetNameByID(int id)
        {
            string Name = "";
            tblemployee obj = Miscdb.tblemployees.Where(a => a.emp_cd.Equals(id)).FirstOrDefault();
            string filename = HttpContext.Current.Server.MapPath("~/Content/EmpImages/" + id + ".jpg");
            if (obj != null)
            {
                Name = obj.Name;
                if (File.Exists(filename))
                {
                    Name = Name + "|True";
                }
                else
                {
                    Name = Name + "|False";
                }
            }
            return Name;
        }


        public string getdistrict(int id)
        {
            string Name = "";

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
                   ).Where(c => c.teh_cd == id)
                   .FirstOrDefault();

            if (person != null)
                
                {
                Name = person.Dist_Name;
            }
        //}

            //var cities = matric_new.tblDistricts.Join(matric_new.tblTehsils.  .Where(c => c.dist_cd == teh);
       
            //string Name = "";
            //tblemployee obj = Miscdb.tblemployees.Where(a => a.emp_cd.Equals(id)).FirstOrDefault();
            //string filename = HttpContext.Current.Server.MapPath("~/Content/EmpImages/" + id + ".jpg");
            //if (obj != null)
            //{
            //    Name = obj.Name;
            //    if (File.Exists(filename))
            //    {
            //        Name = Name + "|True";
            //    }
            //    else
            //    {
            //        Name = Name + "|False";
            //    }
            //}
            return Name;
        }

        //[HttpPost]
        //public void ActionResesult([FromBody] tblemployee model)
        //{

        //    var obj = Miscdb.tblemployees.Where(a => a.emp_cd.Equals(model.emp_cd) && a.pass.Equals(model.pass)).FirstOrDefault();
        //    if (obj != null)
        //    {
        //        //HttpContext.Current.Session["UserID"] = obj.emp_cd.ToString();
        //        //HttpContext.Current.Session["UserName"] = obj.Name.ToString();
        //        //return RedirectToAction("Index", "Home");

        //    }
        //    return View();
        //}

    }
}
