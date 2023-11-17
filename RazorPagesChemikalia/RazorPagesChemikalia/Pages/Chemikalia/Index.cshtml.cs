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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesChemikalia.Data.RazorPagesChemikaliaContext _context;

        public IndexModel(RazorPagesChemikalia.Data.RazorPagesChemikaliaContext context)
        {
            _context = context;
        }

        public IList<Chemikalium> Chemikalium { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Zapachy { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ChemikaliumZapach { get; set; }

        public async Task OnGetAsync()
        {
            // use LINQ to get list of zapachy.
            IQueryable<string> zapachQuery = from m in _context.Chemikalium
                                            orderby m.Zapach
                                            select m.Zapach;

            var chemikalia = from m in _context.Chemikalium
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                chemikalia = chemikalia.Where(s => s.Nazwa.Contains(SearchString));
            }
            
            if (!string.IsNullOrEmpty(ChemikaliumZapach))
            {
                chemikalia = chemikalia.Where(x => x.Zapach == ChemikaliumZapach);
            }
            Zapachy = new SelectList(await zapachQuery.Distinct().ToListAsync());
            Chemikalium = await chemikalia.ToListAsync();
        }
    }
}
