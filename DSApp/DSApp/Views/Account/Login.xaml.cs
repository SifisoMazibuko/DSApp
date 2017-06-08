using MapKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DSApp.Views.Account
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        async void OnClickLoginButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstPage());
            //ICommand WebBrowser = new Command(() => Device.OpenUri(new Uri("https://dstv.com/")));
        }

        async void OnClickForgotButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync (new ForgotPassword());
        }
    }
}