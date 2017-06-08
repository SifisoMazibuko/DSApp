using DSApp.Models;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSApp.Services
{
    public class CustomerService
    {
        public async Task<List<Customers>> PostCustomer()
        {
            RestClient<Customers> restClient = new RestClient<Customers>();
            var customer = await restClient.GetAsync();
            return customer;
        }
    }
}
