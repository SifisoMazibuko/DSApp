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
        public List<MasterPageItem> list { get; set; }
        public MainPage()
        {
            InitializeComponent();
            list = new List<MasterPageItem>();
            
            #region Pages for navigation
                var initial = new MasterPageItem()
                {
                    Title = "Home",
                    Icon = "home.png",
                    TargetType = typeof(HomePage)
                };
                var second = new MasterPageItem()
                {
                    Title = "Login",
                    Icon = "login.png",
                    TargetType = typeof(Login)
                };
                var third = new MasterPageItem()
                {
                    Title = "Register",
                    Icon = "UserRegister.png",
                    TargetType = typeof(Register)
                };
            #endregion

            #region check
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

            //masterPageItems.Add(list);
            //masterPageItems.Add(page2);
            //masterPageItems.Add(page3);


            #endregion

            #region  Adding menu items to list
            list.Add(initial);
            list.Add(second);
            list.Add(third);
            
            navigationDrawerList.ItemsSource = list;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));

            #endregion
        }
        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
             Detail = new NavigationPage((Page)Activator.CreateInstance(page));
           
           
            IsPresented = false;
        }                
    }
}
