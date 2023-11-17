using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesChemikalia.Data;
using RazorPagesChemikalia.Models;

namespace RazorPagesChemikalia.Pages.Chemikalia
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesChemikalia.Data.RazorPagesChemikaliaContext _context;

        public CreateModel(RazorPagesChemikalia.Data.RazorPagesChemikaliaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Chemikalium Chemikalium { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Chemikalium == null || Chemikalium == null)
            {
                return Page();
            }

            _context.Chemikalium.Add(Chemikalium);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
