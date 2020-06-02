using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive.Models;
using TestDrive.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterView : ContentPage
    {
        public MasterViewModel  ViewModel { get; set; }
        public MasterView(Usuario usuario)
        {
            InitializeComponent();
            this.ViewModel = new MasterViewModel(usuario);
            this.BindingContext = this.ViewModel;
        }
    }
}