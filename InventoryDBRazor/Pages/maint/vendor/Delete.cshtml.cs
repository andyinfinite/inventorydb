using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.vendor
{
    public class DeleteModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public DeleteModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ListVendor ListVendor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ListVendor = await _context.ListVendor.FirstOrDefaultAsync(m => m.vendorID == id);

            if (ListVendor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ListVendor = await _context.ListVendor.FindAsync(id);

            if (ListVendor != null)
            {
                _context.ListVendor.Remove(ListVendor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
