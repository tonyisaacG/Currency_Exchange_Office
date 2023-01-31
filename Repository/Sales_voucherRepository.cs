using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Sales_voucherRepository : BaseRepository<Sales_voucher>, ISales_voucherRepository
    {
        public Sales_voucherRepository(DbContextRepository repositoryContext) : base(repositoryContext)
        {
        }
    }
}
