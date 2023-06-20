using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vstrechashop.Models;

namespace ex.Infrastructure.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ApplicationContext _context;

        public CategoriesViewComponent(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync() => View(await _context.Categories.ToListAsync());
    }
}
