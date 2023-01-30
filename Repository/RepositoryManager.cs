using Contracts;
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
        //private readonly Lazy<ICompanyRepository> _companyRepository;
        

        public RepositoryManager(DbContextRepository dbContextRepository)
        {
            _repositoryContext = dbContextRepository;
          //  _employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(_repositoryContext));
        }

        //public IEmployeeRepository Employee => _employeeRepository.Value;

        public void SaveAsync() =>  _repositoryContext.SaveChangesAsync();
    }
}
