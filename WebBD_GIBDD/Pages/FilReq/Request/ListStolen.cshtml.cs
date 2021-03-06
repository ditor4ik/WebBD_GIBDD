using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD_GIBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebBD_GIBDD.Pages.FilReq.Request
{
    public class ListStolenModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public ListStolenModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        public IList<CarsStolen> CarsStolen { get; set; }
        public IList<Auto> Auto { get; set; }
        public IList<Driver> Driver { get; set; }
        public async Task OnGetAsync()
        {
            Auto = await _context.Auto.ToListAsync();
            CarsStolen = await _context.CarsStolen.ToListAsync();
            Driver = await _context.Driver.ToListAsync();
        }
    }
}
