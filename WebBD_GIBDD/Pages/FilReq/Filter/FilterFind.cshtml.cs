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
    public class FilterFindModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public FilterFindModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        public IList<CarsStolen> CarsStolen { get; set; }
        public IList<Auto> Auto { get; set; }
        public IList<Driver> Driver { get; set; }
        public IList<Staff> Staff { get; set; }
        //public bool Title { get; set; }

        public async Task<IActionResult> OnGetAsync(bool? find)
        {
            if(find == null)
            {
                return NotFound();
            }


            CarsStolen = await _context.CarsStolen.Where(m => m.MarkFind == find).ToListAsync();
            Auto = await _context.Auto.ToListAsync();
            Driver = await _context.Driver.ToListAsync();
            Staff = await _context.Staff.ToListAsync();

            return Page();
        }
    }
}
