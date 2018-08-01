using InventoryDBRazor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryDBRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly InventoryDBRazor.Models.InventoryDBContext _context;
        public IndexModel(InventoryDBRazor.Models.InventoryDBContext context)
        {
            _context = context;
        }
        public IList<vwToolCount> ToolCount { get; set; }
        public IList<vwNoLicCount> NoLicCount { get; set; }
        public IList<vwExpiredLicense> ExpLicCount { get; set; }

        public async Task OnGetAsync()
        {
            var prodCount = from p in _context.vwToolCount select p;

            ToolCount = await prodCount
                .OrderBy(p => p.ToolName)
                .ToListAsync();

            var notLicensed = from l in _context.vwNoLicCount select l;

            NoLicCount = await notLicensed
                .OrderBy(p => p.ToolName)
                .ToListAsync();

            var expiredLicense = from e in _context.vwExpiredLicense select e;

            ExpLicCount = await expiredLicense
                .OrderBy(p => p.ToolName)
                .ToListAsync();


        }
    }
}