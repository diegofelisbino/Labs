using System;
using TestDrive.Models;
using TestDrive.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ListagemView(); // padrao
            // MainPage = new NavigationPage(new ListagemView()); // uma pilha de navegação
            MainPage = new LoginView();//login
        }

        protected override void OnStart()
        {
            MessagingCenter.Subscribe<Usuario>(this, "SucessoLogin",
                (usuario) =>
                {
                    //MainPage = new NavigationPage(new ListagemView());
                    MainPage = new MasterDetailView(usuario);
                });
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
