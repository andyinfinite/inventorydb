using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.contacts
{
    public class DetailsModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public DetailsModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public ListContact ListContact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ListContact = await _context.ListContact.FirstOrDefaultAsync(m => m.ContactId == id);

            if (ListContact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
