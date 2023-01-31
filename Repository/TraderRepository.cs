using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TraderRepository : BaseRepository<Trader>, ITraderRepository
    {
        public TraderRepository(DbContextRepository repositoryContext) : base(repositoryContext)
        {
        }
    }
}
