using Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServicesManager: IServicesManager
    {
        private readonly Lazy<IDespositeServices> despositeService;
        public ServicesManager(IRepositoryManager repositoryManager)
        {
            despositeService = new Lazy<IDespositeServices>(() => new DespositeServices(repositoryManager));
        }
        public IDespositeServices DespositeService => despositeService.Value;
    }
}
