using DSApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DSApp.ViewModel
{
    public class LoginViewModel
    {
        private readonly LoginService _logServices = new LoginService();

        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var log = await _logServices.LoginAsync(Username, Password);
                });
            }
        }
    }
}
