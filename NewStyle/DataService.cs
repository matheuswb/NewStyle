using NewStyle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewStyle
{
    public class DataService : IDataService
    {

        private readonly Contexto _contexto;
        public DataService(Contexto contexto)
        {
            // armazenar esse contexto dentro de um campo somente leitura
            this._contexto = contexto;
        }

        public List<ItemPedido> GetItensPedido()
        {
            return this._contexto.ItensPedido.ToList();
        }

        public List<Produto> GetProdutos()
        {
            return this._contexto.Produtos.ToList();
        }

        public void InicializaDB()
        {
            this._contexto.Database.EnsureCreated();
            if (this._contexto.Produtos.Count() == 0)
            {
                List<Produto> produtos = new List<Produto>
                {
                      new Produto ("Vestido azul simples", 59.90m),
                      new Produto ("Vestido azul princesa", 99.50m),
                      new Produto ("Vestido infantil corações", 59.90m),
                      new Produto ("Vestido florido", 69.90m),
                      new Produto ("Camisa social slim fit", 259.90m),
                      new Produto ("Camisa social vinho", 99.50m),
                      new Produto ("Camisa longa jeans escuro", 159.90m),
                      new Produto ("Camiseta New York", 59.90m),
                      new Produto ("Vestido de festa", 129.00m),
                      new Produto ("Vestido cintura fina vermelho", 89.00m),
                      new Produto ("Vestido longo preto", 110.00m),
                      new Produto ("Vestido preto infantil princesa", 69.90m),
                      new Produto ("Vestido 15 anos preto", 88.90m),
                      new Produto ("Vestido cinza simples", 50.00m),
                      new Produto ("Camiseta preta simples", 29.00m),
                      new Produto ("Camisa social clara", 89.00m),
                      new Produto ("Camiseta Michael Jordan", 70.00m),
                      new Produto ("Camisa social azul clara", 99.90m),
                      new Produto ("Camiseta polo cinza", 88.00m),
                      new Produto ("Camiseta polo azul", 88.00m)
                };

                foreach (var produto in produtos)
                {
                    this._contexto.Produtos
                        .Add(produto);


                    this._contexto.ItensPedido
                        .Add(new ItemPedido(produto, 1));
                }

                this._contexto.SaveChanges();

            }
        }

    }
}
