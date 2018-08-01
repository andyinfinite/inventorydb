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
    public class DeleteModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public DeleteModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ListToolType = await _context.ListToolType.FindAsync(id);

            if (ListToolType != null)
            {
                _context.ListToolType.Remove(ListToolType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
