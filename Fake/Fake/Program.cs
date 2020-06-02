using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pessoa = new Faker<Pessoa>("pt_BR")
            //    .RuleFor(c => c.Id, f => f.Random.Guid())
            //    .RuleFor(c => c.Nome, f => f.Name.FullName(Bogus.DataSets.Name.Gender.Female))
            //    .RuleFor(c => c.DataNascimento, f => f.Date.Past(15))
            //    .Generate();

            //Console.WriteLine(@"Dados da pessoa");
            //Console.WriteLine($"ID: {pessoa.Id}");
            //Console.WriteLine($"Nome: {pessoa.Nome}");
            //Console.WriteLine($"Data de Nacimento: {pessoa.DataNascimento.ToShortDateString()}");
            //Console.WriteLine("------------------");



            Console.WriteLine("");
            Console.WriteLine("Exemplo lista:");

            var pessoas = new Faker<Pessoa>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Guid())
                .RuleFor(c => c.Nome, f => f.Name.FullName())
                .RuleFor(c => c.DataNascimento, f => f.Date.Past(15))
                .Generate(3);

            foreach (var pessoaFake in pessoas)
            {
                Console.WriteLine(@"Dados da pessoa");
                Console.WriteLine($"ID: {pessoaFake.Id}");
                Console.WriteLine($"Nome: {pessoaFake.Nome}");
                Console.WriteLine($"Data de Nacimento: {pessoaFake.DataNascimento.ToShortDateString()}");
                Console.WriteLine("------------------");
            }
        }
    }
}
