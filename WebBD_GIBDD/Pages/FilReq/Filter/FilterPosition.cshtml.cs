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
    public class FilterPositionModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;
        public FilterPositionModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }
        public Position Position { get; set; }
        public IList<BD_GIBDD.Models.Rank> Rank { get; set; }
        public IList<Staff> Staff { get; set; }
        
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = await _context.Position.FirstOrDefaultAsync(m => m.ID == id);

            if (Position == null)
            {
                return NotFound();
            }
            Staff = await _context.Staff.Where(m => m.PositionID == Position.ID).ToListAsync();
            Rank = await _context.Rank.ToListAsync();
            return Page();
        }
    }
}
