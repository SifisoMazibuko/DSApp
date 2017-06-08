using DSApp.Models;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSApp.Services
{
    public class ShowService
    {
        public async Task<List<Shows>> GetShows()
        {
            RestClient<Shows> restClient = new RestClient<Shows>();
            var show = await restClient.GetAsync();
            return show;
        }
    }
}
