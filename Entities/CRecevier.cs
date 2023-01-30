using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CRecevier
    {
        [Key]
        public int CR_id { get; set; }
        public string CR_name { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string CR_phoneNum { get; set; }
    }
}
