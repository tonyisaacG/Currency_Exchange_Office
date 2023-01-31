using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Trader
    {
        [Key]
        public int Tad_id { get; set; }
        [Required]
        public string Tad_parCode { get; set; }
        public string Tad_name { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Tad_phone { get; set; }

        public static string GenerateParcode(int id)
        {
            return String.Format("{0}{1}", DateTime.Now.ToString("mmss"), id);
        }
    }
}
