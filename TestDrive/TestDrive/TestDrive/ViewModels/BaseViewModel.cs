using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestDrive.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string name = "")// notificar a view que houve uma mudança de propriedade
        {
            //se diferente de null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
