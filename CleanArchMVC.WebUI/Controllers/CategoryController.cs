using CleanArchMVC.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMVC.WebUI.Controllers
{
    public class CategoryController(ICategoryServices categoryServices) : Controller
    {
        private readonly ICategoryServices _categoryServices = categoryServices;
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _categoryServices.GetCategoriesAsync();
            return View(result);
        }
    }
}
