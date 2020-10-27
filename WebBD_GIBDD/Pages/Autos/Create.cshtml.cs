using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;
using Microsoft.EntityFrameworkCore;

namespace WebBD_GIBDD.Pages.Autos
{
    public class CreateModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public CreateModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }
        public List<SelectListItem> SelTH { get; set; }
        public List<Driver> Driver { get; set; }
        public IList<Staff> Staff { get; set; }
        public IList<BrandAuto> BrandAuto { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
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

        [BindProperty]
        public Auto Auto { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Auto.Add(Auto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
