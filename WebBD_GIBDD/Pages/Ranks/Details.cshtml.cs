using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace WebBD_GIBDD.Pages.Rank
{
    public class DetailsModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public DetailsModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        public BD_GIBDD.Models.Rank Rank { get; set; }

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
            return Page();
        }
    }
}
