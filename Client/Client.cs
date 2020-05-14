using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace lbry.net
{
    public class Client : IAccountClient
    {
        public async Task GetAccountBalance() //<Account.BalanceResponse>
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync("http://localhost:5279", new StringContent(@"{""method"": ""account_balance"", ""params"": {}}"));
            }
        }
    }
}
