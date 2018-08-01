using InventoryDBRazor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryDBRazor.Pages
{
    public class ListModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public ListModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }
        
        public IList<TblMain> Items { get; set; }
 
        public async Task OnGetAsync(string searchString, int? tool, int? tooltype, int? gloc)
        {
               
            var items = from i in _context.TblMain select i;
        
            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.ItemName.Contains(searchString));
            } else if (tool != null) {
                items = items.Where(s => s.ToolName == tool);
            } else if (tooltype != null) {
                items = items.Where(s => s.ItemType == tooltype);
            } else if (gloc != null) {
                items = items.Where(s => s.GeoLocation == gloc);
            }

            Items = await items
                .Include(l => l.ListLocation)
                .Include(t => t.ListTools)
                .Include(tt => tt.ListToolType)
                .Include(s => s.ListStatus)
                .ToListAsync();
        }
    }
}
