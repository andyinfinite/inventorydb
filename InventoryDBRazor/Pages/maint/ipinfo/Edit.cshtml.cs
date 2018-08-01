using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.ipinfo
{
    public class EditModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public EditModel(InventoryDBRazor.Models.InventoryDBContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(IPInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IPInfoExists(IPInfo.IPID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //return RedirectToPage("./Index");
            return LocalRedirect("~/maint/ItemDetailEdit?id=" + IPInfo.itemID);
        }

        private bool IPInfoExists(int id)
        {
            return _context.IPInfo.Any(e => e.IPID == id);
        }
    }
}
