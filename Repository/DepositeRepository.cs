using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DepositeRepository : BaseRepository<Desposit>, IDepositeRepository
    {
        public DepositeRepository(DbContextRepository repositoryContext) : base(repositoryContext)
        {

        }

        public void CreateDesposite(Desposit desposit)
        {
            Create(desposit);
        }

        public void DeleteDesposite(Desposit desposit)
        {
            Delete(desposit);
        }

        public IEnumerable<Desposit> GetAllDesposite(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

      
        public Desposit GetDesposite(int Id, bool trackChanges)
        {
            var desposit =  FindByCondition(e => e.Despt_id.Equals(Id), trackChanges).FirstOrDefault();
            return desposit;
        }
    }
}
