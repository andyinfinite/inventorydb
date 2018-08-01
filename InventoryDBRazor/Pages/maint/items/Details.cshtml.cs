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
    public class DetailsModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public DetailsModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public TblMain TblMain { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblMain = await _context.TblMain
                .Include(t => t.ListLocation)
                .Include(t => t.ListStatus)
                .Include(t => t.ListToolType)
                .Include(t => t.ListTools).FirstOrDefaultAsync(m => m.ItemId == id);

            if (TblMain == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
