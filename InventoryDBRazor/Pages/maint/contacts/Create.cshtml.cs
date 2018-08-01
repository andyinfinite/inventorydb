using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.contacts
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
            return Page();
        }

        [BindProperty]
        public ListContact ListContact { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ListContact.Add(ListContact);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}