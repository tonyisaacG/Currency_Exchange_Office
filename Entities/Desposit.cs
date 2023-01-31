using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Desposit
    {
        [Key]
        public int Despt_id { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Despt_money_prv { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Despt_money_add { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Despt_money_now { get; set; }
        [DataType(DataType.Date)]
        public DateTime Despt_date { get; set; }

        [ForeignKey(nameof(Client))]
        public int Client_id { get; set; }
        public Client Client { get; set; }
    }
}
