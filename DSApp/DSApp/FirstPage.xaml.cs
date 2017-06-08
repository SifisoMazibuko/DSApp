using DSApp.MenuItems;
using DSApp.Views.Account;
using DSApp.Views.DSTV;
using DSApp.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DSApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : MasterDetailPage
    {
        public List<MasterPageItem> MenuList { get; set; }
        public FirstPage()
        {

            InitializeComponent();

            MenuList = new List<MasterPageItem>();

            // Navigation menu
            #region Pages for navigation
            var initial = new MasterPageItem() { Title = "Home", Icon = "home.png", TargetType = typeof(HomePage) };
            var second = new MasterPageItem() { Title = "TV Guide", Icon = "guide.png", TargetType = typeof(HomePage) };
            var third = new MasterPageItem() { Title = "Catch Up", Icon = "catchup.png", TargetType = typeof(HomePage) };
            var fourth = new MasterPageItem() { Title = "Live TV", Icon = "tv.png", TargetType = typeof(HomePage) };
            var fifth = new MasterPageItem() { Title = "Profile", Icon = "profile.png", TargetType = typeof(HomePage) };

            #endregion

            // Adding menu items to menuList
            MenuList.Add(initial);
            MenuList.Add(second);
            MenuList.Add(third);
            MenuList.Add(fourth);
            MenuList.Add(fifth);
            
            navigationDrawerList.ItemsSource = MenuList;
            // Initial navigation
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