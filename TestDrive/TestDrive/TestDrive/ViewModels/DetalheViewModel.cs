using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using TestDrive.Models;
using Xamarin.Forms;

namespace TestDrive.ViewModels
{
    public class DetalheViewModel : BaseViewModel
    {
        public Veiculo Veiculo { get; set; }
        public string TextoFreioABS
        {
            get
            {
                return $"Freio ABS - R$ {Veiculo.FREIO_ABS}";
            }
        }

        public string TextoArCondicionado
        {
            get
            {
                return $"Ar Condicionado - R$ {Veiculo.AR_CONDICIONADO}";
            }
        }

        public string TextoMP3Player
        {
            get
            {
                return $"MP3 Player - R$ {Veiculo.MP3_PLAYER}";
            }
        }

        public bool TemFreioABS
        {
            get { return Veiculo.TemFreioABS; }
            set
            {
                Veiculo.TemFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemArCondicionado
        {
            get { return Veiculo.TemArCondicionado; }
            set
            {
                Veiculo.TemArCondicionado = value;
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemMP3Player
        {
            get { return Veiculo.TemMP3Player; }
            set
            {
                Veiculo.TemMP3Player = value;
                OnPropertyChanged(nameof(ValorTotal));
            }
        }


        public string ValorTotal
        {
            get
            {
                return Veiculo.PrecoTotalFormatado;
            }
        }

       

        public ICommand ProximoCommand { get; set; }
        public DetalheViewModel(Veiculo veiculo)
        {
            this.Veiculo = veiculo;

            ProximoCommand = new Command(() =>
            {
                MessagingCenter.Send(veiculo, "Proximo");
            });
        }
    }
}
