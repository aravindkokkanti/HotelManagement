using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class AddressTypeModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Date is Required")]
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        [Required(ErrorMessage = "ID is Required")]
        public Nullable<int> CREATEDBY { get; set; }
        public bool ISACTIVE { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public Nullable<int> MODIFIEDBY { get; set; }
    }
}
