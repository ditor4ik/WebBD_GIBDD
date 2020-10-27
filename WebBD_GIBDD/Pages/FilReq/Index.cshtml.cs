using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebBD_GIBDD.Pages.FilReq
{

    public class IndexModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;
        public IndexModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {

            _context = context;
        }
        public List<SelectListItem> SelPosition { get; set; }
        public IActionResult OnGet()
        {
            SelPosition = _context.Position.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.NamePosition
                                  }).ToList();

            return Page();
        }
    }
}
