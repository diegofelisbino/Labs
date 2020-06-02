using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestDrive.Models;
using Xamarin.Forms;

namespace TestDrive.ViewModels
{
    //<!-- Binding Context definido no codigo xaml-->
    public class LoginViewModel
    {
        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set
            {

                usuario = value;
                ((Command)EntrarCommand).ChangeCanExecute(); //houve uma mudança no valor da propriedade
            }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                ((Command)EntrarCommand).ChangeCanExecute(); //houve uma mudança no valor da propriedade
            }
        }

        public ICommand EntrarCommand { get; private set; }

        public  LoginViewModel()
        {
            //comando para o botao
            EntrarCommand = new Command( async () =>
            {
                var loginService = new LoginService();
                await loginService.FazerLogin(new Login(usuario, senha));
            }, () => //funcao anonima
            {
                return !string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha);
            });

        }

    }
}
