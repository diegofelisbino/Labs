using System;
using System.Collections.Generic;
using System.Text;

namespace CheckList.App.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string dataNascimento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }

    public class LoginResult
    {
        public Usuario usuario { get; set; }
    }
}
