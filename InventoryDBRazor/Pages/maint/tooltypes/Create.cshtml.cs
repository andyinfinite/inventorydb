using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.tooltypes
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
        public ListToolType ListToolType { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ListToolType.Add(ListToolType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}