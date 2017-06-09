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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }
        ////private async void Button_OnClicked(object sender, EventArgs e)
        ////{
        ////    await Navigation.PushAsync(new Login());
        ////}
    }
}