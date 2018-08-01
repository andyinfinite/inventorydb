using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.items
{
    public class IndexModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public IndexModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public IList<TblMain> TblMain { get; set; }

        public async Task OnGetAsync()
        {
            TblMain = await _context.TblMain
                .Include(t => t.ListLocation)
                .Include(t => t.ListStatus)
                .Include(t => t.ListToolType)
                .Include(t => t.ListTools).ToListAsync();
        }
    }
}
