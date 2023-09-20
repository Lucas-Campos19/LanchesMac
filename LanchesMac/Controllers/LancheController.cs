using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;   
        }
        public IActionResult List()
        {
            //ViewData["Titulo"] = "Todos os lanches";
            //ViewData["Data"] = DateTime.Now;
            //var lanches = _lancheRepository.Lanches;
            //var totalLanches = lanches.Count();
            //ViewBag.Total = "Total de Lanches";
            //ViewBag.TotalLanches = totalLanches;
            //return View(lanches);

            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lanchesListViewModel);
        }
    }
}
