using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {
        [Key]
        public int Client_id { get; set; }
        public string Client_name { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Client_phoneNum { get; set; }
        [DataType(DataType.Currency)]
        public decimal Client_money { get; set; }

    }
}
