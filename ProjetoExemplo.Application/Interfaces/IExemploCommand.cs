using ProjetoExemplo.Application.Modulo.Exemplos.Models;
using System.Threading.Tasks;

namespace ProjetoExemplo.Application.Interfaces
{
    public interface IExemploCommand
    {
        Task<ExemploModel> AdicionarAsync(ExemploModel exemplo);
        Task<ExemploModel> AtualizarAsync(ExemploModel exemplo);
        Task<int> ExcluirAsync(ExemploModel exemplo);
    }
}
