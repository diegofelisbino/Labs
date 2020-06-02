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
    public partial class AgendamentoView : ContentPage
    {
        public AgendamentoViewModel ViewModel { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.ViewModel = new AgendamentoViewModel(veiculo);
            this.BindingContext = this.ViewModel;
        }
        protected  override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Agendamento>(this, "Agendamento",
                async (msg) =>
                {
                    var confirma = await DisplayAlert("Salvar Agendamento", "Deseja mesmo enviar o agendamento?", "Sim", "Não");

                    if (confirma)
                    {
                        this.ViewModel.SalvarAgendamento();
                    }
                });

            //assinou a mensagem de sucesso
            MessagingCenter.Subscribe<Agendamento>(this, "SucessoAgendamento",
                (msg) =>
                {
                    DisplayAlert("Agendamento", "Agendamento salvo com sucesso!", "Ok");
                });

            //assinou a mensagem de falha
            MessagingCenter.Subscribe<ArgumentException>(this, "FalhaAgendamento",
                (msg) =>
                {
                    DisplayAlert("Agendamento", "Falha ao agendar o test driver!Verifique os dados e tente novamente mais tarde!", "Ok");
                });

        }

        protected override void OnDisappearing()
        {
            //cancelar assinatura ao fechar a tela
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Agendamento>(this, "Agendamento");

            MessagingCenter.Unsubscribe<Agendamento>(this, "SucessoAgendamento");

            MessagingCenter.Unsubscribe<ArgumentException>(this, "FalhaAgendamento");
        }
    }
}