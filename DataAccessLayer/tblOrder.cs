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
    
    public partial class tblOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrder()
        {
            this.tblOrderDeliveries = new HashSet<tblOrderDelivery>();
        }
    
        public int Id { get; set; }
        public string PERSONNAME { get; set; }
        public string PERSONPHONENUMBER { get; set; }
        public Nullable<int> MENUITEMID { get; set; }
        public int QTY { get; set; }
        public Nullable<System.DateTime> ORDERFERDATE { get; set; }
        public decimal TOTALPRICE { get; set; }
        public bool ISACTIVE { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public Nullable<int> MODIFIEDBY { get; set; }
    
        public virtual tblMenuItem tblMenuItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderDelivery> tblOrderDeliveries { get; set; }
    }
}
