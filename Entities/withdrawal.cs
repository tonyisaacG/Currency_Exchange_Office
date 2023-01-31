using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class withdrawal
    {
        [Key]
        public int Withd_id { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName ="money")]
        public decimal Withd_money { get; set; }
        [DataType(DataType.Date)]
        public DateTime Withd_date { get; set; } = DateTime.Now;

        [ForeignKey(nameof(Client))]
        public int Client_id { get; set; }
        public Client Client { get; set; }
    }
}
