using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using static Android.Provider.SyncStateContract;
using DSApp.Models;

namespace DSApp.Services
{
    public class RegisterService
    {
        private const string WebServiceUrl = "http://http://localhost:30421/api/Account/Register/";
        public async Task<bool> RegisterUserAsync(string username,string firstName, string surname,
            string dob,string gender,string country,string province,string phone,string email, string password)
        {
            var client = new HttpClient();

            var model = new Customers
            {
                UserName = username,
                FirstName =firstName,
                SurName = surname,
                Dob = dob,
                Gender = gender,
                Province = province,
                Phone = phone,
                Email = email,
                Password = password
            };

            var json = JsonConvert.SerializeObject(model);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(WebServiceUrl, httpContent);
                      

            return response.IsSuccessStatusCode;
        }
    }
}
