using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CRecevierRepository : BaseRepository<CRecevier>, ICRecevierRepository
    {
        public CRecevierRepository(DbContextRepository repositoryContext) : base(repositoryContext)
        {
        }
    }
}
