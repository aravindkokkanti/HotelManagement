using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class GenderModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Gender Name is Required")]
        public string Name { get; set; }
        public bool ISACTIVE { get; set; }
      
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public Nullable<int> MODIFIEDBY { get; set; }
    }
}
