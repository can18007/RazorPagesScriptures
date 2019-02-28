using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesScriptures.Models
{
    public class RazorPagesScripturesContext : DbContext
    {
        public RazorPagesScripturesContext (DbContextOptions<RazorPagesScripturesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesScriptures.Models.Movie> Movie { get; set; }
    }
}
