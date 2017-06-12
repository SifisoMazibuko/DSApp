using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DSApp.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            //Create a button
            Button button = new Button
            {
                Text = "Link To Account",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BackgroundColor = Color.DeepSkyBlue,
                HeightRequest = 50,
                WidthRequest = 250,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnClickButton;
           
            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    button,
                }
            };
        }

        void OnClickButton(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://now.dstv.com/Home/Login?returnUrl=http%3A%2F%2Fnow.dstv.com%2FLiveTv"));
            //ICommand WebBrowser = new Command(() => Device.OpenUri(new Uri("https://dstv.com/")));
        }
        
        public ICommand WebBrowser { get; }
    }
}