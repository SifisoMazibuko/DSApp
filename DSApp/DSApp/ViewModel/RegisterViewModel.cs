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
    public class RegisterViewModel
    {
        private readonly RegisterService _regServices = new RegisterService();

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }
        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var reg = await _regServices.RegisterUserAsync(UserName,FirstName, SurName, DOB, 
                        Gender, Country, Province, Phone, Email, Password);                   
                    
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
