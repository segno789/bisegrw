using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    [Serializable]
    public class User
    {
        public string ID { set; get; }
        public int Emp_cd { get; set; }
        public string Name { get; set; }
        public string FName { get; set; }
        public string Pass { get; set; }
        public string Desig { get; set; }
        public int BS { get; set; }
        public string MobileNo { get; set; }
        public int Branch_Code { get; set; }
        public int IsActive { get; set; }
        public string Email { get; set; }
        public int User_type { get; set; }
        public bool IsSuperAdmin { get; set; }
        public int Class { get; set; }
        public string about { get; set; }
    }
}
