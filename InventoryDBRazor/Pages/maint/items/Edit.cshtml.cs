using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.items
{
    public class EditModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public EditModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["GeoLocation"] = new SelectList(_context.ListLocation, "LocationID", "LocationName");
           ViewData["StatusID"] = new SelectList(_context.ListStatus, "StatusID", "Status");
           ViewData["ItemType"] = new SelectList(_context.ListToolType, "TypeId", "ToolType");
           ViewData["ToolName"] = new SelectList(_context.ListTools, "ToolId", "ToolName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TblMain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblMainExists(TblMain.ItemId))
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

        private bool TblMainExists(int id)
        {
            return _context.TblMain.Any(e => e.ItemId == id);
        }
    }
}
