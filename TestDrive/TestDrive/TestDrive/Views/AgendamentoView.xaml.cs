using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        public Veiculo Veiculo { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }

        private DateTime dataAgendamento = DateTime.Today;

        public DateTime DataAgendamento
        {
            get { return dataAgendamento; }
            set { dataAgendamento = value; }
        }

        private TimeSpan horaAgendamento;

        public TimeSpan HoraAgendamento
        {
            get { return horaAgendamento; }
            set { horaAgendamento = value; }
        }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            Veiculo = veiculo;
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           
            
            DisplayAlert("Agendamento", 
                $"Nome: {Nome} \n" +
                $"Fone: {Fone} \n" +
                $"E-Mail: {Email} \n" +
                $"Data Agendamento: {DataAgendamento.ToString("dd/MM/yyyy")} \n" +
                $"Hora Agendamento: {HoraAgendamento} " 
                , "Okay");
        }
    }
}