using System;
using System.Collections.Generic;
using System.Text;
using TestDrive.Models;

namespace TestDrive.ViewModels
{
    public class MasterViewModel
    {		

		public string Nome
		{
			get { return this.usuario.nome; }
			set { this.usuario.nome = value; }
		}
		public string Email
		{
			get { return this.usuario.email; }
			set { this.usuario.email = value; }
		}

		private readonly Usuario usuario;
		public MasterViewModel(Usuario usuario)
		{
			this.usuario = usuario;
		}
	}
}
