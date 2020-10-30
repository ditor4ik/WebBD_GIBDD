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
    public class FilterRankModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;
        public FilterRankModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }
        public IList<Position> Position { get; set; }
        public BD_GIBDD.Models.Rank Rank { get; set; }
        public IList<Staff> Staff { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rank = await _context.Rank.FirstOrDefaultAsync(m => m.ID == id);

            if (Rank == null)
            {
                return NotFound();
            }
            Staff = await _context.Staff.Where(m => m.RankID == Rank.ID).ToListAsync();
            Position = await _context.Position.ToListAsync();
            return Page();
        }
    }
}
