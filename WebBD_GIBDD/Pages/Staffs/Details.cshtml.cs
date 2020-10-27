﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_GIBDD.Models;
using WebBD_GIBDD.Data;

namespace WebBD_GIBDD.Pages.Staffs
{
    public class DetailsModel : PageModel
    {
        private readonly WebBD_GIBDD.Data.WebBD_GIBDDContext _context;

        public DetailsModel(WebBD_GIBDD.Data.WebBD_GIBDDContext context)
        {
            _context = context;
        }

        public Staff Staff { get; set; }
        public BD_GIBDD.Models.Rank Rank { get; set; }
        public BD_GIBDD.Models.Position Position { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Staff = await _context.Staff.FirstOrDefaultAsync(m => m.ID == id);
            Rank = await _context.Rank.FirstOrDefaultAsync(m => m.ID == Staff.RankID);
            Position = await _context.Position.FirstOrDefaultAsync(m => m.ID == Staff.PositionID);

            if (Staff == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
