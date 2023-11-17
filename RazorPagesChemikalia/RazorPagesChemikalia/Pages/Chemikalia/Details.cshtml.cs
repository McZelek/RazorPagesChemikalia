using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesChemikalia.Data;
using RazorPagesChemikalia.Models;

namespace RazorPagesChemikalia.Pages.Chemikalia
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesChemikalia.Data.RazorPagesChemikaliaContext _context;

        public DetailsModel(RazorPagesChemikalia.Data.RazorPagesChemikaliaContext context)
        {
            _context = context;
        }

      public Chemikalium Chemikalium { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Chemikalium == null)
            {
                return NotFound();
            }

            var chemikalium = await _context.Chemikalium.FirstOrDefaultAsync(m => m.Id == id);
            if (chemikalium == null)
            {
                return NotFound();
            }
            else 
            {
                Chemikalium = chemikalium;
            }
            return Page();
        }
    }
}
