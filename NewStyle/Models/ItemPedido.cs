using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewStyle.Models
{
    public class ItemPedido
    {

        public int Id { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal PrecoUnitario { get; private set; }
        public decimal Subtotal
        {
            get
            {
                return Quantidade * PrecoUnitario;
            }
        }

        public ItemPedido(int id, Produto produto, int quantidade) : this (produto, quantidade)
        {
            this.Id = id;
        }


        //Construtor sem id. id é auto incrementavel 
        public ItemPedido(Produto produto, int quantidade)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.PrecoUnitario = produto.Preco;
        }

        public ItemPedido()
        {

        }

    }
}
