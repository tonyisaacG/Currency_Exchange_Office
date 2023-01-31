using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(DbContextRepository repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Client> GetAllClients(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Client GetCLientByName(string name, bool trackChanges)
        {
            return FindByCondition(client => client.Client_name == name, trackChanges).FirstOrDefault();
        }
    }
}
