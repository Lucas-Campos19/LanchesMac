using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using LanchesMac.Models;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace LanchesMac.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRespository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRespository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRespository = lancheRespository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();

            _carrinhoCompra.CarrinhoCompraItem = itens;
            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };
            return View(carrinhoCompraVM);
        }

        [Authorize]
        public IActionResult AdicionarItemNoCarrinhoCompra( int lancheId)
        {
                var lancheSelecionado = _lancheRespository.Lanches.FirstOrDefault(p => p.LancheId == lancheId);

                if (lancheSelecionado != null)
                {
                    _carrinhoCompra.AdicionarAoCarrinho(lancheSelecionado);
                }
                
               return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult RemoverItemDoCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado  = _lancheRespository.Lanches.FirstOrDefault(p => p.LancheId == lancheId);
            if(lancheSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(lancheSelecionado);
            }
            return RedirectToAction("Index");
        }
    }
}
