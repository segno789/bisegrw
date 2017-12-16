using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL
{
    public class SessionWrapper
    {

        public static User User
        {
            set
            {
                HttpContext.Current.Session["User"] = value;
            }
            get
            {
                if (HttpContext.Current.Session["User"] != null)
                {
                    return HttpContext.Current.Session["User"] as User;
                }
                return null;
            }
        }


        public static string ImageURL
        {
            set
            {
                HttpContext.Current.Session["HiddenPicture"] = value;
            }
            get
            {
                if (HttpContext.Current.Session["HiddenPicture"] != null)
                {
                    return HttpContext.Current.Session["HiddenPicture"].ToString();
                }
                return string.Empty;
            }

        }
        public static bool ImageUploaded
        {
            set
            {
                HttpContext.Current.Session["IsImageUploaded"] = value;
            }
            get
            {
                if (HttpContext.Current.Session["IsImageUploaded"] != null)
                {
                    return Convert.ToBoolean(HttpContext.Current.Session["IsImageUploaded"]);
                }
                return false;
            }
        }



        //==================work by hanzala======================== 

        public static int Class
        {
            set { HttpContext.Current.Session["Class"] = value; }
            get
            {
                if (HttpContext.Current.Session["Class"] != null)
                {
                    return Convert.ToInt32(HttpContext.Current.Session["Class"]);
                }
                return 0;
            }
        }



        public static int Year
        {
            set { HttpContext.Current.Session["Year"] = value; }
            get
            {

                if (HttpContext.Current.Session["Year"] != null)
                {
                    return Convert.ToInt32(HttpContext.Current.Session["Year"]);
                }
                return 0;
            }
        }

        public static int Session
        {
            set { HttpContext.Current.Session["Session"] = value; }
            get
            {
                if (HttpContext.Current.Session["Session"] != null)
                {
                    return Convert.ToInt32(HttpContext.Current.Session["Session"]);
                }
                return 0;
            }
        }

        public static int BranchCode
        {
            set { HttpContext.Current.Session["BranchCode"] = value; }
            get
            {
                if (HttpContext.Current.Session["BranchCode"] != null)
                {
                    return Convert.ToInt32(HttpContext.Current.Session["BranchCode"]);
                }
                return 0;
            }
        }
    }
}
