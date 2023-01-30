using Contracts;
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
    }
}
