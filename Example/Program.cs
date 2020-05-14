using System;
using System.Threading.Tasks;

namespace lbry.net
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IAccountClient client = new Client("http://localhost:5279");
            var result = await client.GetBalance();
        }
    }
}
