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
        public List<SelectListItem> SelRank { get; set; }
        public List<SelectListItem> SelDriver { get; set; }
        public List<SelectListItem> SelTechInsp { get; set; }
        public List<SelectListItem> SelFind { get; set; }
        public IActionResult OnGet()
        {
            SelPosition = _context.Position.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.NamePosition
                                  }).ToList();
            SelRank = _context.Rank.Select(r =>
                                  new SelectListItem
                                  {
                                      Value = r.ID.ToString(),
                                      Text = r.NameRank
                                  }).ToList();
            SelDriver = _context.Driver.Select(d =>
                                  new SelectListItem
                                  {
                                      Value = d.ID.ToString(),
                                      Text = d.FullName
                                  }).ToList();
            SelTechInsp = new List<SelectListItem>
                        {
                           new SelectListItem{ Value = "1", Text = "Прошел"},
                           new SelectListItem{ Value = "0", Text = "Не прошел"}
                        };
            SelFind = new List<SelectListItem>
                        {
                           new SelectListItem{ Value = "True", Text = "Найден"},
                           new SelectListItem{ Value = "False", Text = "Не найден"}
                        };
            return Page();
        }
    }
}
