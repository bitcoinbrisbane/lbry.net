using System;
using System.Threading.Tasks;
using lbry.net;

namespace lbry.net
{
    public interface IAccountClient
    {
        Task<Account.BalanceResponse> GetBalance();

        Task<Response<Name.Result>> GetName();
    }
}