using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.locations
{
    public class DetailsModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public DetailsModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public ListLocation ListLocation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ListLocation = await _context.ListLocation.FirstOrDefaultAsync(m => m.LocationID == id);

            if (ListLocation == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
