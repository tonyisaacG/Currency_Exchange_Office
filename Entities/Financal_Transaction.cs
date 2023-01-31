using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Financal_Transaction
    {
        [Key]
        public int FT_id { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal FT_amount { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal FT_tranferedAmount { get; set; }
        [DataType(DataType.Date)]
        public DateTime FT_date { get; set; }
        public string FT_transferType { get; set; }
        public string FT_currencyType { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public float FT_exchangeRate { get; set; }
        public string FT_countery { get; set; }


        [ForeignKey(nameof(CRecevier))]
        public int CRecevier_id { get; set; }
        public CRecevier CRecevier { get; set; }


        [ForeignKey(nameof(Client))]
        public int Client_id { get; set; }
        public Client Client { get; set; }
    }
}
