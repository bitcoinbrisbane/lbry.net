using System;
using System.Net.Http;
using System.Threading.Tasks;
using lbry.net;

namespace lbry.net
{
    public class Client : IAccountClient
    {
        private readonly string _node;

        public Client(string node)
        {
            _node = node;
        }

        public async Task<Account.BalanceResponse> GetBalance()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync(_node, new StringContent(@"{""method"": ""account_balance"", ""params"": {}}"));
                string json = await response.Content.ReadAsStringAsync();

                Account.BalanceResponse balance = Newtonsoft.Json.JsonConvert.DeserializeObject<Account.BalanceResponse>(json);
                return balance;
            }
        }

        public async Task<Response<Name.Result>> GetName()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync(_node, new StringContent(@"{""method"": ""account_balance"", ""params"": {}}"));
                string json = await response.Content.ReadAsStringAsync();

                Account.BalanceResponse balance = Newtonsoft.Json.JsonConvert.DeserializeObject<Account.BalanceResponse>(json);
                return balance;
            }
        }
    }
}
