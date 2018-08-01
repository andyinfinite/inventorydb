using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.ipinfo
{
    public class CreateModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public int newIPID;
        public CreateModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
            newIPID = id;
            return Page();
        }

        [BindProperty]
        public IPInfo IPInfo { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.IPInfo.Add(IPInfo);
            await _context.SaveChangesAsync();

            return LocalRedirect("~/maint/ItemDetailEdit?id=" + IPInfo.itemID);
        }
    }
}