using EvaraMVC.DataContext;
using EvaraMVC.Modals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EvaraMVC.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly EvaraDbContext _evardbContext;
        private EvaraDbContext _evarDbContext;

        public CategoryController(EvaraDbContext dbContext)
        {
            _evarDbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            List<Category> categories=await _evardbContext.Categories.ToListAsync();
            return View(categories);
        }
    }
}
