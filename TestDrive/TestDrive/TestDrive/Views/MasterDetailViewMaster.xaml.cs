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

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailViewMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailViewMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailViewMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailViewMasterMenuItem> MenuItems { get; set; }

            public MasterDetailViewMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailViewMasterMenuItem>(new[]
                {
                    new MasterDetailViewMasterMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailViewMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailViewMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailViewMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailViewMasterMenuItem { Id = 4, Title = "Page 5" },
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