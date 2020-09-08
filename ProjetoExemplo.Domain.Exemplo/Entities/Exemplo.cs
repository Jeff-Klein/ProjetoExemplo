using System;

namespace ProjetoExemplo.Domain.Entities.Modulo.Exemplo
{
    public class Exemplo : Base
    {
        public Exemplo(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public string Nome { get; private set; }

        internal string AlterarNome(string nome)
        {
            if (nome != string.Empty)
                this.Nome = nome;

            return this.Nome;
        }
    }
}
