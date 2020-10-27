using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;

namespace WebBD_GIBDD.Pages.Staffs
{
    public class CreateModel : PageModel
    {

        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public CreateModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {

            _context = context;
        }
        public List<SelectListItem> SelPosition { get; set; }
        public List<SelectListItem> SelRank { get; set; }
        public List<SelectListItem> SelGender { get; set; }
        public IActionResult OnGet()
        {
            SelPosition = _context.Position.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.NamePosition
                                  }).ToList();

            SelRank = _context.Rank.Select(r =>
                                  new SelectListItem
                                  {
                                      Value = r.ID.ToString(),
                                      Text = r.NameRank
                                  }).ToList();
            SelGender = new List<SelectListItem>
                        {
                           new SelectListItem{ Value = "Мужчина", Text = "Мужчина"},
                           new SelectListItem{ Value = "Женщина", Text = "Женщина"}
                        };
            return Page();
        }

        [BindProperty]
        public Staff Staff { get; set; }
        public List<SelectListItem> ListStaff { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Staff.Add(Staff);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
