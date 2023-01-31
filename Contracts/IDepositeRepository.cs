using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IDepositeRepository
    {
        IEnumerable<Desposit> GetAllDesposite(bool trackChanges);
        Desposit GetDesposite(int Id, bool trackChanges);
        void CreateDesposite(Desposit desposit);
    }
}
