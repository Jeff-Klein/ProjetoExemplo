using ProjetoExemplo.Application.Modulo.Exemplos.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoExemplo.Application.Interfaces
{
    public interface IExemploQuery
    {
        Task<IEnumerable<ExemploModel>> BuscarTodosAsync();
        Task<ExemploModel> ObterAsync(Guid id);
    }
}
