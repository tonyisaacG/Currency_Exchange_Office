using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class WithdrawalRepository : BaseRepository<withdrawal>, IWithdrawalRepository
    {
        public WithdrawalRepository(DbContextRepository repositoryContext) : base(repositoryContext)
        {
        }
    }
}
