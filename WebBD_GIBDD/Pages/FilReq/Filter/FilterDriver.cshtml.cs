using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD_GIBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebBD_GIBDD.Pages.FilReq.Filter
{
    public class FilterDriverModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;
        public FilterDriverModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }
        public Driver Driver { get; set; }
        public IList<Staff> Staff { get; set; }
        public IList<BrandAuto> BrandAuto { get; set; }
        public IList<Auto> Auto { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Driver = await _context.Driver.FirstOrDefaultAsync(m => m.ID == id);

            if (Driver == null)
            {
                return NotFound();
            }
            Auto = await _context.Auto.Where(m => m.DriverID == Driver.ID).ToListAsync();
            BrandAuto = await _context.BrandAuto.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
            return Page();
        }
    }
}
