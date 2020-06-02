using CheckList.App.Models;
using CheckList.App.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckList.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }

        protected override void OnStart()
        {
            MessagingCenter.Subscribe<Usuario>(this, "SucessoLogin",
                (usuario) =>
                {
                    MainPage = new NavigationPage(new Views.Page1());
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
