using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesChemikalia.Data;
using RazorPagesChemikalia.Models;

namespace RazorPagesChemikalia.Pages.Chemikalia
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesChemikalia.Data.RazorPagesChemikaliaContext _context;

        public EditModel(RazorPagesChemikalia.Data.RazorPagesChemikaliaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Chemikalium Chemikalium { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Chemikalium == null)
            {
                return NotFound();
            }

            var chemikalium =  await _context.Chemikalium.FirstOrDefaultAsync(m => m.Id == id);
            if (chemikalium == null)
            {
                return NotFound();
            }
            Chemikalium = chemikalium;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Chemikalium).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChemikaliumExists(Chemikalium.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ChemikaliumExists(int id)
        {
          return (_context.Chemikalium?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
