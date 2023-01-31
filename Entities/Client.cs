using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {
       
        [Key]
        public int Client_id { get; set; }
        [Required]
        public string Client_parCode { get; set; }
        public string Client_name { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Client_phoneNum { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Client_money { get; set; }


        public static string GenerateParcode(int id)
        {
            return String.Format("{0}{1}", DateTime.Now.ToString("mmss"), id);
        }

    }
}
