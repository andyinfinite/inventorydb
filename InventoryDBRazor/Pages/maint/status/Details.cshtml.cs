using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.status
{
    public class DetailsModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public DetailsModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public ListStatus ListStatus { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ListStatus = await _context.ListStatus.FirstOrDefaultAsync(m => m.StatusID == id);

            if (ListStatus == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
