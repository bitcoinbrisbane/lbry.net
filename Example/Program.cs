using System;
using System.Threading.Tasks;

namespace lbry.net
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Client client = new Client();
            await client.GetAccountBalance();
        }
    }
}
