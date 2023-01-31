using Contracts;
using Entities;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DespositeServices:IDespositeServices
    {
        private readonly IRepositoryManager repositoryManager;

        public DespositeServices(IRepositoryManager _repositoryManager)
        {
            repositoryManager = _repositoryManager;
        }

        public void AddDesposite(Desposit desposit)
        {
            repositoryManager.DepositeRepository.CreateDesposite(desposit);
        }

        public IEnumerable<Client> GetAllClients(bool trackChanges)
        {
            return repositoryManager.ClientRepository.GetAllClients(trackChanges);
        }

        public IEnumerable<Desposit> GetAllDesposite(bool trackChanges)
        {
            return repositoryManager.DepositeRepository.GetAllDesposite(trackChanges);
        }
    }
}
