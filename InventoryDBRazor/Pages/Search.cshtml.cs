using InventoryDBRazor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryDBRazor.Pages
{
    public class SearchModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public SearchModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }
        
        public IList<vwSearch> Items { get; set; }


        public async Task OnGetAsync(string searchString)
        {
            var items = from i in _context.vwSearch select i;

            if (!String.IsNullOrEmpty(searchString))
            {
                Items = await items.FromSql("EXEC sp_FindStringInTable '%" + searchString + "%', 'dbo', 'vwSearch'").ToListAsync();
            } else
            {
                Items = null;
            }

        }
    }
}
