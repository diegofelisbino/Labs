using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckList.Api.Model
{
    public class Funcionario
    {
        public int Registro { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Setor { get; set; }
    }
}
