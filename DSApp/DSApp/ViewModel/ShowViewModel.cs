using DSApp.Models;
using DSApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSApp.ViewModel
{
    public  class ShowViewModel : INotifyPropertyChanged
    {
        private List<Shows> showsList;

        public List<Shows> ShowsList
        {
            get { return showsList; }
            set
            {
                showsList = value;
            }
        }
        public ShowViewModel()
        {
            InitialAsync();
        }
        public async Task InitialAsync()
        {
            var showServices = new ShowService();
            ShowsList = await showServices.GetShows();
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
