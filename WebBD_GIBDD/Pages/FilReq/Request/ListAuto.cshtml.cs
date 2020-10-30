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
    public class ListAutoModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public ListAutoModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        public IList<Auto> Auto { get; set; }
        public IList<BrandAuto> BrandAuto { get; set; }
        public IList<Driver> Driver { get; set; }
        public IList<Staff> Staff { get; set; }
        public async Task OnGetAsync()
        {
            Auto = await _context.Auto.ToListAsync();
            BrandAuto = await _context.BrandAuto.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
            Driver = await _context.Driver.ToListAsync();
        }
    }
}
