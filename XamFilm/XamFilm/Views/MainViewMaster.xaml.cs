using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFilm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainViewMaster : ContentPage
    {
        public ListView ListView;

        public MainViewMaster()
        {
            InitializeComponent();

            BindingContext = new MainViewMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainViewMenuItem> MenuItems { get; set; }
            
            public MainViewMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainViewMenuItem>(new[]
                {
                    new MainViewMenuItem { Id = 0, Title = "Page 1" },
                    new MainViewMenuItem { Id = 1, Title = "Page 2" },
                    new MainViewMenuItem { Id = 2, Title = "Page 3" },
                    new MainViewMenuItem { Id = 3, Title = "Page 4" },
                    new MainViewMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}