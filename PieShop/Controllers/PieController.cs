using Microsoft.AspNetCore.Mvc;
using PieShop.Models.Contracts;
using PieShop.Models.ViewModels;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(ICategoryRepository categoryRepository, IPieRepository pieRepository)
        {
            _categoryRepository = categoryRepository;
            _pieRepository = pieRepository;
        }

        public ViewResult List()
        {
            // return View(_pieRepository.AllPies);
            PieViewModel piesVM = new PieViewModel();
            piesVM.Pies = _pieRepository.AllPies;
            piesVM.CurrentCategory = "Cheese Cakes";
            return View(piesVM);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }

    }
}
