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

namespace WebBD_GIBDD.Pages.Drivers
{
    public class EditModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public EditModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Driver Driver { get; set; }
        public List<SelectListItem> SelCatAuto { get; set; }
        public IList<Staff> Staff { get; set; }
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
            var group1 = new SelectListGroup() { Name = "Легковой автомототранспорт" };
            var group2 = new SelectListGroup() { Name = "Грузовые автомобили" };
            var group3 = new SelectListGroup() { Name = "Пассажирский транспорт" };
            SelCatAuto = new List<SelectListItem>
            {
                new SelectListItem{ Value = "A", Text = "A", Group = group1},
                new SelectListItem{ Value = "A1", Text = "A1", Group = group1},
                new SelectListItem{ Value = "B", Text = "B", Group = group1},
                new SelectListItem{ Value = "B1", Text = "B1", Group = group1},
                new SelectListItem{ Value = "M", Text = "M", Group = group1},

                new SelectListItem{ Value = "C", Text = "C", Group = group2},
                new SelectListItem{ Value = "C1", Text = "C1", Group = group2},
                new SelectListItem{ Value = "CE", Text = "CE", Group = group2},
                new SelectListItem{ Value = "C1E", Text = "C1E", Group = group2},

                new SelectListItem{ Value = "D", Text = "D", Group = group3},
                new SelectListItem{ Value = "D1", Text = "D1", Group = group3},
                new SelectListItem{ Value = "DE", Text = "DE", Group = group3},
                new SelectListItem{ Value = "D1E", Text = "D1E", Group = group3},
                new SelectListItem{ Value = "Tb", Text = "Tb", Group = group3},
                new SelectListItem{ Value = "Tm", Text = "Tm", Group = group3}
            };

            Staff = await _context.Staff.ToListAsync();
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

            _context.Attach(Driver).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DriverExists(Driver.ID))
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

        private bool DriverExists(long id)
        {
            return _context.Driver.Any(e => e.ID == id);
        }
    }
}
