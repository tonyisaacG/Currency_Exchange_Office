using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager: IRepositoryManager
    {
        private readonly DbContextRepository _repositoryContext;
        private readonly Lazy<IDepositeRepository> despositeRepository;
        

        public RepositoryManager(DbContextRepository dbContextRepository)
        {
            _repositoryContext = dbContextRepository;
            despositeRepository = new Lazy<IDepositeRepository>(() => new DepositeRepository(_repositoryContext));
        }

        public IDepositeRepository Desposite => despositeRepository.Value;

        public void SaveAsync() =>  _repositoryContext.SaveChangesAsync();
    }
}
