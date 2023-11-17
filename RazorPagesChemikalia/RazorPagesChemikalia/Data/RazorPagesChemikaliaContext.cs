using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesChemikalia.Models;

namespace RazorPagesChemikalia.Data
{
    public class RazorPagesChemikaliaContext : DbContext
    {
        public RazorPagesChemikaliaContext (DbContextOptions<RazorPagesChemikaliaContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesChemikalia.Models.Chemikalium> Chemikalium { get; set; } = default!;
    }
}
