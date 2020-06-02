using CheckList.App.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CheckList.App.ViewModels
{
    public class LoginViewModel
    {
		private string usuario;
		public string Usuario
		{
			get { return usuario; }
			set 
			{ 
				usuario = value;
				((Command)EntrarCommand).ChangeCanExecute(); //validar se houver mudanca no valor
			}
		}

		private string senha;
		public string Senha
		{
			get { return senha; }
			set 
			{ 
				senha = value;
				((Command)EntrarCommand).ChangeCanExecute(); //validar se houver mudanca no valor
			}
		}

		public ICommand EntrarCommand { get; private set; } //botão entrar

		public LoginViewModel()
		{			
			EntrarCommand = new Command(() =>
			{
				MessagingCenter.Send<Usuario>(new Usuario(), "SucessoLogin");
			}, () => //funçao anonima
			{
				return !string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha);
			});
		}
	}
}
