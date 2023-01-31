using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Shopping_VoucherRepository : BaseRepository<Shopping_Voucher>, IShopping_VoucherRepository
    {
        public Shopping_VoucherRepository(DbContextRepository repositoryContext) : base(repositoryContext)
        {
        }
    }
}
