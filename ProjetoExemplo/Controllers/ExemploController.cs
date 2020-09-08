using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoExemplo.Application.Interfaces;
using ProjetoExemplo.Application.Modulo.Exemplos.Models;

namespace ProjetoExemplo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExemploController : ControllerBase
    {
        private readonly IExemploQuery _exemploQuery;

        public ExemploController(IExemploQuery exemploQuery)
        {
            _exemploQuery = exemploQuery;
        }

        [HttpGet]
        public async Task<IEnumerable<ExemploModel>> BuscarTodosAsync()
        {
            return await _exemploQuery.BuscarTodosAsync();
        }
    }
}
