﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;
using Microsoft.EntityFrameworkCore;

namespace WebBD_GIBDD.Pages.Drivers
{
    public class CreateModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public CreateModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }
        public List<SelectListItem> SelCatAuto { get; set; }
        public IList<Staff> Staff { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
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

        [BindProperty]
        public Driver Driver { get; set; }
        

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Driver.Add(Driver);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
