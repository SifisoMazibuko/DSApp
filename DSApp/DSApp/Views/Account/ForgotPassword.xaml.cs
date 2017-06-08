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
    public partial class ForgotPassword : ContentPage
    {
        public ForgotPassword()
        {
            InitializeComponent();
            Email.Focus();
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
           
        }

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
        }
    }
}