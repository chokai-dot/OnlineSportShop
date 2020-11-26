using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineSportShop.Pages.Models;

namespace OnlineSportShop.Models
{
    public class IndexModel : PageModel
    {
        private readonly OnlineSportShop.Pages.Models.CatalogDBContext _context;

        public IndexModel(OnlineSportShop.Pages.Models.CatalogDBContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
