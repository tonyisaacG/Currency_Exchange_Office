using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Shopping_Voucher
    {
        [Key]
        public int ShV_id { get; set; }
        public string ShV_merchantAccount { get; set; }
        public string ShV_paymentMethod { get; set; }
        [DataType(DataType.Currency)]
        public decimal ShV_Quantity { get; set; }
        public string ShV_currencyType { get; set; }
        [DataType(DataType.Currency)]
        public decimal ShV_transeferPrice { get; set; }
        [DataType(DataType.Currency)]
        public decimal ShV_totalAmount { get; set; }
        [DataType(DataType.Date)]
        public DateTime ShV_date { get; set; }

        [ForeignKey(nameof(Trader))]
        public int Trader_id { get; set; }
        public Trader Trader { get; set; }
    }
}
