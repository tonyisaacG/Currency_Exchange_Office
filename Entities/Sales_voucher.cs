using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sales_voucher
    {
        [Key]
        public int SaV_id { get; set; }
        public string SaV_paymentMethod { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal SaV_Quantity { get; set; }
        public string SaV_currencyType { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal SaV_transeferPrice { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal SaV_totalAmount { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal SaV_CostPrice { get; set; }
        [DataType(DataType.Date)]
        public DateTime SaV_date { get; set; }

        [ForeignKey(nameof(Trader))]
        public int Trader_id { get; set; }
        public Trader Trader { get; set; }

    }
}
