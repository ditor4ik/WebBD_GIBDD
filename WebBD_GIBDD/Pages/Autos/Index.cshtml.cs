using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;

namespace WebBD_GIBDD.Pages.Autos
{
    public class IndexModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public IndexModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        public IList<Auto> Auto { get; set; }
        public IList<Staff> Staff { get; set; }
        public IList<Driver> Driver { get; set; }
        public IList<BrandAuto> BrandAuto { get; set; }

        public async Task OnGetAsync()
        {
            Auto = await _context.Auto.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
            Driver = await _context.Driver.ToListAsync();
            BrandAuto = await _context.BrandAuto.ToListAsync();
        }
    }
}
