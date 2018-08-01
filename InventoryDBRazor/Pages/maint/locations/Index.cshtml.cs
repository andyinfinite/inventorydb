using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.locations
{
    public class IndexModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public IndexModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public IList<ListLocation> ListLocation { get;set; }

        public async Task OnGetAsync()
        {
            ListLocation = await _context.ListLocation.ToListAsync();
        }
    }
}
