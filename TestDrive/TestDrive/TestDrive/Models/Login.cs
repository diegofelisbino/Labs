using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrive.Models
{
    public class Login
    {
        public string Email { get; private set; }
        public string Senha { get; private set; }

        public Login(string email, string senha)
        {
            this.Email = email;
            this.Senha = senha;
        }
    }

    
}
