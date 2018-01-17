using NewStyle.Models;
using System.Collections.Generic;

namespace NewStyle
{
    public interface IDataService
    {
        void InicializaDB();
        List<Produto> GetProdutos();
        List<ItemPedido> GetItensPedido();
    }
}