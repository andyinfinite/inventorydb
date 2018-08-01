using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages
{
    public class ItemDetailModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public ItemDetailModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public IList<TblMain> ItemDetail { get; set; }
        public IList<IPInfo> ItemIPInfo { get; set; }
        public int? pagenum;

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
                .Where(i => i.ItemId == id)
                .ToListAsync();

            ItemIPInfo = await _context.IPInfo
                .Where(m => m.itemID == id)
                .ToListAsync();

            pagenum = id;

            return Page();
        }
        
    }
}