using DSApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using DSApp.Models;
using Plugin.RestClient;
  

namespace DSApp.ViewModel
{
    public class RegisterViewModel
    {
       private readonly RegisterService<Customers> _regServices = new RegisterService<Customers>();

        private RestClient<Customers> _restClient = new RestClient<Customers>();

        public Customers model = new Customers();
        public string Message { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    //var reg = await _regServices.RegisterUserAsync(model

                    var reg = await _restClient.PostAsync(model);

                    if (reg)
                    {
                        Message = "Successfully registered :)";
                    }
                    else
                    {
                        Message = "Please try again :(";
                    }
                });

            }

        }
    }
}
