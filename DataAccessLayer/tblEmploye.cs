//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEmploye
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AADHARNO { get; set; }
        public decimal SALARY { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public Nullable<int> GENDERID { get; set; }
        public Nullable<int> ADDRESSID { get; set; }
        public Nullable<int> CUSTOMERID { get; set; }
        public Nullable<int> ROLEID { get; set; }
        public bool ISACTIVE { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public Nullable<int> MODIFIEDBY { get; set; }
    
        public virtual tblAddress tblAddress { get; set; }
        public virtual tblCustomer tblCustomer { get; set; }
        public virtual tblGender tblGender { get; set; }
        public virtual tblRole tblRole { get; set; }
    }
}
