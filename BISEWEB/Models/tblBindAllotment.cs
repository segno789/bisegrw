//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BISEWEB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBindAllotment
    {
        public int Emp_cd { get; set; }
        public int Session { get; set; }
        public int Year { get; set; }
        public int Class { get; set; }
        public Nullable<int> TotalAllotment { get; set; }
        public Nullable<int> NoOfBinds { get; set; }
        public Nullable<int> StartingBind { get; set; }
        public Nullable<int> EndingBind { get; set; }
        public Nullable<int> branch_Code { get; set; }
        public Nullable<System.DateTime> edate { get; set; }
    }
}
