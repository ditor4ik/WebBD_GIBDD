using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;

namespace WebBD_GIBDD.Pages.CarsStolens
{
    public class DeleteModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public DeleteModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CarsStolen CarsStolen { get; set; }
        public Driver Driver { get; set; }
        public Auto Auto { get; set; }
        public Staff Staff { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarsStolen = await _context.CarsStolen.FirstOrDefaultAsync(m => m.ID == id);

            if (CarsStolen == null)
            {
                return NotFound();
            }
            Driver = await _context.Driver.FirstOrDefaultAsync(m => m.ID == CarsStolen.DriverID);
            Auto = await _context.Auto.FirstOrDefaultAsync(m => m.ID == CarsStolen.AutoID);
            Staff = await _context.Staff.FirstOrDefaultAsync(m => m.ID == CarsStolen.StaffID);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarsStolen = await _context.CarsStolen.FindAsync(id);

            if (CarsStolen != null)
            {
                _context.CarsStolen.Remove(CarsStolen);
                await _context.SaveChangesAsync();
            }



            return RedirectToPage("./Index");
        }
    }
}
