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
    public class ItemDetailEdit : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public ItemDetailEdit(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblMain ItemDetail { get; set; }
        public IList<IPInfo> ItemIPInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemDetail = await _context.TblMain
                .Include(t => t.ListLocation)
                .Include(t => t.ListStatus)
                .Include(t => t.ListToolType)
                .Include(t => t.ListTools)
                .Where(y => y.ItemId == id)
                .FirstOrDefaultAsync();

            ItemIPInfo = await _context.IPInfo
                .Where(n => n.itemID == id)
                .ToListAsync();

            ViewData["ToolName"] = new SelectList(_context.ListTools.OrderBy(t => t.ToolName), "ToolId", "ToolName");
            ViewData["ToolType"] = new SelectList(_context.ListToolType.OrderBy(tt => tt.ToolType), "TypeId", "ToolType");
            ViewData["GeoLocation"] = new SelectList(_context.ListLocation.OrderBy(l=> l.LocationName), "LocationID", "LocationName");
            ViewData["StatusID"] = new SelectList(_context.ListStatus.OrderBy(s => s.Status), "StatusID", "Status");

            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ItemDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemDetailExists(ItemDetail.ItemId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return LocalRedirect("~/ItemDetail?id=" + ItemDetail.ItemId);
        }

        private bool ItemDetailExists(int id)
        {
            return _context.TblMain.Any(e => e.ItemId == id);
        }
    }
}