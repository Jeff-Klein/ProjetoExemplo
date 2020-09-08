using Microsoft.EntityFrameworkCore;
using ProjetoExemplo.Domain.Entities.Modulo.Exemplo;

namespace ProjetoExemplo.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Exemplo> Exemplos { get; set; }
    }
}
