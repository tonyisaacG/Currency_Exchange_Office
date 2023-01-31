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
        private readonly Lazy<IClientRepository> clientRepository;
        private readonly Lazy<ICRecevierRepository> cRecevierRepository;
        private readonly Lazy<IFinancalTransRepository> financalTransRepository;
        private readonly Lazy<ISales_voucherRepository> sales_VoucherRepository;
        private readonly Lazy<IShopping_VoucherRepository> shopping_VoucherRepository;
        private readonly Lazy<ITraderRepository> traderRepository;
        private readonly Lazy<IWithdrawalRepository> withdrawalRepository;

        public RepositoryManager(DbContextRepository dbContextRepository)
        {
            _repositoryContext = dbContextRepository;
            despositeRepository = new Lazy<IDepositeRepository>(() => new DepositeRepository(_repositoryContext));
            clientRepository = new Lazy<IClientRepository>(() => new ClientRepository(_repositoryContext));
            cRecevierRepository = new Lazy<ICRecevierRepository>(() => new CRecevierRepository(_repositoryContext));
            financalTransRepository = new Lazy<IFinancalTransRepository>(() => new FinancalTransRepository(_repositoryContext));
            sales_VoucherRepository = new Lazy<ISales_voucherRepository>(() => new Sales_voucherRepository(_repositoryContext));
            shopping_VoucherRepository = new Lazy<IShopping_VoucherRepository>(() => new Shopping_VoucherRepository(_repositoryContext));
            traderRepository = new Lazy<ITraderRepository>(() => new TraderRepository(_repositoryContext));
            withdrawalRepository = new Lazy<IWithdrawalRepository>(() => new WithdrawalRepository(_repositoryContext));
        }

        public IDepositeRepository DepositeRepository => despositeRepository.Value;

        public IClientRepository ClientRepository => clientRepository.Value;

        public ICRecevierRepository CRecevierRepository => cRecevierRepository.Value;

        public IFinancalTransRepository FinancalTransRepository => financalTransRepository.Value;

        public ISales_voucherRepository Sales_VoucherRepository => sales_VoucherRepository.Value;

        public IShopping_VoucherRepository Shopping_VoucherRepository => shopping_VoucherRepository.Value;

        public ITraderRepository TraderRepository => traderRepository.Value;

        public IWithdrawalRepository WithdrawalRepository => withdrawalRepository.Value;

        public void Save() =>  _repositoryContext.SaveChanges();
    }
}
