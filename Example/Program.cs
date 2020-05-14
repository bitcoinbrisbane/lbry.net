using System;
using System.Threading.Tasks;

namespace lbry.net
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Client client = new Client();
            var result = await client.GetAccountBalance();
        }
    }
}
