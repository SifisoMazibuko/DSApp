using DSApp.Models;
using DSApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DSApp.ViewModel
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        private Customers _customer = new Customers();

      
        public CustomerViewModel()
        {
            InitialAsync();
        }
        
        public Customers customer
        {
            get { return _customer; }
            set { _customer = value;
                OnSelectedPropertyChanged();
            }
        }

        public Command SendCommand
        {
            get {
                return new Command(async () =>
               {
                   var customerServices = new CustomerService();
                   await customerServices.PostCustomer();
               });
            }
        }
        public async Task InitialAsync()
        {
            var customerServices = new CustomerService();
          //  _customer = await customerServices.PostCustomer();
        }

        /// <summary>
        /// Occurs when property value changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnSelectedPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
