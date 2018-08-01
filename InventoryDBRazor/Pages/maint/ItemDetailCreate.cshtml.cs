using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint
{
    public class ItemDetailCreate : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public ItemDetailCreate(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblMain ItemDetail { get; set; }

        public IActionResult OnGet()
        {
            ViewData["ToolName"] = new SelectList(_context.ListTools, "ToolId", "ToolName");
            ViewData["ToolType"] = new SelectList(_context.ListToolType, "TypeId", "ToolType");
            ViewData["GeoLocation"] = new SelectList(_context.ListLocation, "LocationID", "LocationName");
            ViewData["StatusID"] = new SelectList(_context.ListStatus, "StatusID", "Status");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblMain.Add(ItemDetail);
            await _context.SaveChangesAsync();

            return LocalRedirect("~/maint/ItemDetailEdit?id=" + ItemDetail.ItemId);
        }
    }
}