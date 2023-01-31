using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IDespositeServices
    {
        
        void AddDesposite(Desposit desposit);
        IEnumerable<Desposit> GetAllDesposite(bool trackChanges);
        IEnumerable<Client> GetAllClients(bool trackChanges);
    }
}
