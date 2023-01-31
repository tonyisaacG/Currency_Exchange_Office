using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IDepositeRepository DepositeRepository { get; }
        IClientRepository ClientRepository { get; }
        ICRecevierRepository CRecevierRepository { get; }
        IFinancalTransRepository FinancalTransRepository { get; }
        ISales_voucherRepository Sales_VoucherRepository { get; }
        IShopping_VoucherRepository Shopping_VoucherRepository { get; }
        ITraderRepository TraderRepository { get; }
        IWithdrawalRepository WithdrawalRepository { get; }

        void Save();
    }
}
