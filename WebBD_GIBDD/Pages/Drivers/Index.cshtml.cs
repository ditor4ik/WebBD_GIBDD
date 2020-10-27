using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;

namespace WebBD_GIBDD.Pages.Drivers
{
    public class IndexModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public IndexModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        public IList<Driver> Driver { get;set; }
        public IList<BD_GIBDD.Models.Staff> Staff { get; set; }
        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
            Driver = await _context.Driver.ToListAsync();
        }
    }
}
