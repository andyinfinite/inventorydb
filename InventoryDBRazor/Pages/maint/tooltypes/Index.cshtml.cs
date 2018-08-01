using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.tooltypes
{
    public class IndexModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public IndexModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public IList<ListToolType> ListToolType { get;set; }

        public async Task OnGetAsync()
        {
            ListToolType = await _context.ListToolType.ToListAsync();
        }
    }
}
