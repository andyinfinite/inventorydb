using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.items
{
    public class CreateModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public CreateModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["GeoLocation"] = new SelectList(_context.ListLocation, "LocationID", "LocationID");
            ViewData["StatusID"] = new SelectList(_context.ListStatus, "StatusID", "StatusID");
            ViewData["ItemType"] = new SelectList(_context.ListToolType, "TypeId", "TypeId");
            ViewData["ToolName"] = new SelectList(_context.ListTools, "ToolId", "ToolId");
            return Page();
        }

        [BindProperty]
        public TblMain TblMain { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblMain.Add(TblMain);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}