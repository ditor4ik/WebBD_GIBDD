using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WebBD_GIBDD.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public IndexModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; }
        public IList<BD_GIBDD.Models.Rank> Rank { get; set; }
        public IList<BD_GIBDD.Models.Position> Position { get; set; }
        public async Task OnGetAsync()
        {
            Rank = await _context.Rank.ToListAsync();
            Position = await _context.Position.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
