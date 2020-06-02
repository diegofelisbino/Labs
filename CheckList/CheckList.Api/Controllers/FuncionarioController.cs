using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CheckList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Model.Funcionario>> Get()
        {
            var funcionario = new Faker<Model.Funcionario>("pt_BR")
          .RuleFor(c => c.Registro, f => f.Random.Int(10000, 20000))
          .RuleFor(c => c.Nome, f => f.Name.FullName())
          .RuleFor(c => c.DataNascimento, f => f.Person.DateOfBirth)
          .RuleFor(c => c.Setor, f => f.Commerce.Department())
          .Generate();

            return Ok(funcionario);
        }
    }
}