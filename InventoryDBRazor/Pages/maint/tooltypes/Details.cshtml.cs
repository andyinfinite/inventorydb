using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.tooltypes
{
    public class DetailsModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public DetailsModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public ListToolType ListToolType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ListToolType = await _context.ListToolType.FirstOrDefaultAsync(m => m.TypeId == id);

            if (ListToolType == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
