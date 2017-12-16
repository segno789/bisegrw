using BISEWEB.Models;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BISEWEB.Controllers
{
    public class Generics
    {
        MiscDbEntities Miscdb = new MiscDbEntities();
        matric_newEntities matric_new = new matric_newEntities();

        public List<tblParentNode> GetNodes()
        {
            List<tblParentNode> obj = null;

            if (SessionWrapper.User.IsSuperAdmin == true)
            {
                obj = new List<tblParentNode>();
                obj = (from t in matric_new.tblChildNodes
                       from z in matric_new.tblParentNodes
                       where z.ParentNodeID == t.ParentNodeID
                       select z).Distinct().ToList();
            }
            else
            {
                //((isCommon = 1) or ChildNodeID in (select formNo from MiscDb..tblWebRights  where  formNo not in(select ChildNodeID from  matric_new..tblChildNodes  where isCommon = 1) and UserID = 1093))

                //var query = from item in db.myTable
                //            where ids.Contains(item.ID)
                //            select item;

                using (var context = new matric_newEntities())
                {
                    int[] rightNodes = matric_new.Database.SqlQuery<int>(@"select a.ChildNodeID from matric_new..tblParentNodes b, matric_new..tblChildNodes a  where a.ParentNodeID = b.ParentNodeID and 
                    ((isCommon = 1) or ChildNodeID in (select formNo from MiscDb..tblWebRights  where formNo not in(select ChildNodeID from matric_new..tblChildNodes  where isCommon = 1) and UserID = " + SessionWrapper.User.Emp_cd + "))").ToArray<int>();
                    HttpContext.Current.Session["FormRights"] = rightNodes;

                    obj = new List<tblParentNode>();
                    obj = (from z in matric_new.tblParentNodes
                           join t in matric_new.tblChildNodes on z.ParentNodeID equals t.ParentNodeID
                           where (rightNodes.Contains(t.ChildNodeID))
                           select z).Distinct().ToList();
                }
            }

            return obj;

        }



    }
}