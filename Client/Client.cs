using System;
using System.Net.Http;
using System.Threading.Tasks;
using lbry.net;

namespace lbry.net
{
    public class Client : IAccountClient
    {
        public async Task<Account.BalanceResponse> GetAccountBalance() //<Account.BalanceResponse>
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync("http://localhost:5279", new StringContent(@"{""method"": ""account_balance"", ""params"": {}}"));
                string json = await response.Content.ReadAsStringAsync();

                lbry.net.Account.BalanceResponse balance = Newtonsoft.Json.JsonConvert.DeserializeObject<lbry.net.Account.BalanceResponse>(json);
                return balance;
            }
        }
    }
}
