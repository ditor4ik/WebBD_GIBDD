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

namespace WebBD_GIBDD.Pages.Staffs
{
    public class EditModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public EditModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        public List<SelectListItem> SelPosition { get; set; }
        public List<SelectListItem> SelRank { get; set; }
        public List<SelectListItem> SelGender { get; set; }

        [BindProperty]
        public Staff Staff { get; set; }
        public BD_GIBDD.Models.Rank Rank { get; set; }
        public BD_GIBDD.Models.Position Position { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
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

            Staff = await _context.Staff.FirstOrDefaultAsync(m => m.ID == id);
            Rank = await _context.Rank.FirstOrDefaultAsync(m => m.ID == Staff.RankID);
            Position = await _context.Position.FirstOrDefaultAsync(m => m.ID == Staff.PositionID);

            if (Staff == null)
            {
                return NotFound();
            }
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

            _context.Attach(Staff).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffExists(Staff.ID))
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

        private bool StaffExists(long id)
        {
            return _context.Staff.Any(e => e.ID == id);
        }
    }
}
