using Microsoft.AspNetCore.Mvc;
using NewStyle.Models;
using NewStyle.Models.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewStyle.Controllers
{
    public class PedidoController : Controller
    {

        private readonly IDataService _dataService;
        public PedidoController(IDataService dataService)
        {
            this._dataService = dataService;
        }

        public IActionResult Carrossel()
        {
            List<Produto> produtos = _dataService.GetProdutos();
            return View(produtos);
            //retorna os produtos para o carrossel
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();

            return View(viewModel);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            //No dataService temos o get de produtos 
            List<Produto> produtos = this._dataService.GetProdutos();
            var itensCarrinho = this._dataService.GetItensPedido();

            CarrinhoViewModel viewModel =
                new CarrinhoViewModel(itensCarrinho);
            return viewModel;
        }

        public IActionResult Resumo()
        {

            CarrinhoViewModel viewModel = GetCarrinhoViewModel();

            return View(viewModel);
        }
    }
}
