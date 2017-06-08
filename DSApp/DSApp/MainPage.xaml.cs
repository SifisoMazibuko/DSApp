using DSApp.MenuItems;
using DSApp.Views.Account;
using DSApp.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DSApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> MenuList { get; set; }
        public MainPage()
        {

            InitializeComponent();

            MenuList = new List<MasterPageItem>();

            // Navigation menu 
            #region Pages for navigation
                var initial = new MasterPageItem() { Title = "Home", Icon = "home.png", TargetType = typeof(HomePage) };
                var second = new MasterPageItem() { Title = "Login", Icon = "login.png", TargetType = typeof(Login) };
                var third = new MasterPageItem() { Title = "Register", Icon = "UserRegister.png", TargetType = typeof(Register) };

            #endregion



            //var masterPageItems = new List<MasterPageItem>();
            //masterPageItems.Add(new MasterPageItem
            //{
            //    Title = "Home",
            //    Icon = "home.png",
            //    TargetType = typeof(HomePage)
            //});
            //masterPageItems.Add(new MasterPageItem
            //{
            //    Title = "Login",
            //    Icon = "login.png",
            //    TargetType = typeof(Login)
            //});
            //masterPageItems.Add(new MasterPageItem
            //{
            //    Title = "Register",
            //    Icon = "Register.png",
            //    TargetType = typeof(Register)
            //});

            //masterPageItems.Add(MenuList);
            //masterPageItems.Add(page2);
            //masterPageItems.Add(page3);


            // Adding menu items to menuList
            MenuList.Add(initial);
            MenuList.Add(second);
            MenuList.Add(third);


            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = MenuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));


        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }                
    }
}
