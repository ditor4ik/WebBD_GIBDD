using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;

namespace WebBD_GIBDD.Pages.Autos
{
    public class DetailsModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public DetailsModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        public Auto Auto { get; set; }
        public Staff Staff { get; set; }
        public Driver Driver { get; set; }
        public BrandAuto BrandAuto { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Auto = await _context.Auto.FirstOrDefaultAsync(m => m.ID == id);

            if (Auto == null)
            {
                return NotFound();
            }
            Staff = await _context.Staff.FirstOrDefaultAsync(m => m.ID == Auto.StaffID);
            Driver = await _context.Driver.FirstOrDefaultAsync(m => m.ID == Auto.DriverID);
            BrandAuto = await _context.BrandAuto.FirstOrDefaultAsync(m => m.ID == Auto.BrandAutoID);
            return Page();
        }
    }
}
