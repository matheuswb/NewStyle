using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewStyle.Models
{
    public class ProdutoMasc
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }

        public ProdutoMasc (int id, string nome, decimal preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
        }

    }
}
