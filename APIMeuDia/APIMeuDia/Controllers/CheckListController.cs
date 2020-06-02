using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIMeuDia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckListController : ControllerBase
    {      
        // POST: api/CheckList
        [HttpPost]
        public ActionResult Post(Model.Questionario questionario)
        {            
            Model.Funcionario funcionario = this.GetFuncionarioFake();         

            return Ok();
        }

        
        public Model.Funcionario GetFuncionarioFake()
        {
            var funcionario = new Faker<Model.Funcionario>("pt_BR")
                .RuleFor(c => c.Registro, f => f.Random.Int(10000, 20000))
                .RuleFor(c => c.Nome, f => f.Name.FullName())
                .RuleFor(c => c.DataNascimento, f => f.Person.DateOfBirth)
                .RuleFor(c => c.Setor, f => f.Commerce.Department())
                .Generate();

            return funcionario;
        }
    }
}
