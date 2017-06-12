using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using DSApp.Models;
using System.Diagnostics;

namespace DSApp.Services
{
    public  class LoginService
    {
        private const string WebServiceUrl = "http://localhost:30421/api/Account/";
        public async Task<bool> LoginAsync(string userName, string password)
        {
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", userName),
                new KeyValuePair<string, string>("password", password),
            };

            var request = new HttpRequestMessage(HttpMethod.Post, WebServiceUrl);
            request.Content = new FormUrlEncodedContent(keyValues);
            var client = new HttpClient();
            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            return true;
        }
    }
}
