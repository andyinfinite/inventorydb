using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.ipinfo
{
    public class DeleteModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public DeleteModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IPInfo IPInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            IPInfo = await _context.IPInfo.FirstOrDefaultAsync(m => m.IPID == id);

            if (IPInfo == null)
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

            IPInfo = await _context.IPInfo.FindAsync(id);

            if (IPInfo != null)
            {
                _context.IPInfo.Remove(IPInfo);
                await _context.SaveChangesAsync();
            }

            return LocalRedirect("~/maint/ItemDetailEdit?id=" + IPInfo.itemID);
        }
    }
}
