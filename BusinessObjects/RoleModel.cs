using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class RoleModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Code Is Required")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }
        public bool ISACTIVE { get; set; }
        [Required(ErrorMessage = "DATE Is Required")]
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        [Required(ErrorMessage = "ID Is Required")]
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public Nullable<int> MODIFIEDBY { get; set; }

    }
}
