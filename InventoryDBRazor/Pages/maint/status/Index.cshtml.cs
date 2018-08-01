using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Pages.maint.status
{
    public class IndexModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;

        public IndexModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }

        public IList<ListStatus> ListStatus { get;set; }

        public async Task OnGetAsync()
        {
            ListStatus = await _context.ListStatus.ToListAsync();
        }
    }
}
