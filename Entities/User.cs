using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        [Key]
        public int User_id { get; set; }
        public string User_name { get; set; }
        public string User_role { get; set; }
    }
}
