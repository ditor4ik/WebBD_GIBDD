using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;

namespace WebBD_GIBDD.Pages.Autos
{
    public class EditModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public EditModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }
        public List<SelectListItem> SelTH { get; set; }
        public List<Driver> Driver { get; set; }
        public List<Staff> Staff { get; set; }
        public List<BrandAuto> BrandAuto { get; set; }

        [BindProperty]
        public Auto Auto { get; set; }

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
            SelTH = new List<SelectListItem>
                        {
                           new SelectListItem{ Value = "Прошел", Text = "Прошел"},
                           new SelectListItem{ Value = "Не прошел", Text = "Не прошел"}
                        };
            Staff = await _context.Staff.ToListAsync();
            Driver = await _context.Driver.ToListAsync();
            BrandAuto = await _context.BrandAuto.ToListAsync();
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Auto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoExists(Auto.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AutoExists(long id)
        {
            return _context.Auto.Any(e => e.ID == id);
        }
    }

}
