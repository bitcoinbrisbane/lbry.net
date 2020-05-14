using System;
using System.Threading.Tasks;

namespace lbry.net
{
    public interface IAccountClient
    {
        Task GetAccountBalance();
    }
}