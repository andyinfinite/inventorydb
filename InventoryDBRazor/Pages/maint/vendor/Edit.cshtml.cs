using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.vendor
{
    public class EditModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public EditModel(InventoryDBRazor.Models.InventoryDBContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ListVendor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListVendorExists(ListVendor.vendorID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ListVendorExists(int id)
        {
            return _context.ListVendor.Any(e => e.vendorID == id);
        }
    }
}
