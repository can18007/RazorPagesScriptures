using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesScriptures.Models;

namespace RazorPagesScriptures.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesScriptures.Models.RazorPagesScripturesContext _context;

        public IndexModel(RazorPagesScriptures.Models.RazorPagesScripturesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }
        [BindProperty(SupportsGet = true)]
        public string search { get; set; }


        [BindProperty(SupportsGet = true)]
        public string search2 { get; set; }

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureNotes { get; set; }

        public async Task OnGetAsync()
        {
           
            var book = from m in _context.Movie
                         select m;

            if (!string.IsNullOrEmpty(search))
            {
                book = book.Where(s => s.Book.Contains(search));
            } if (!string.IsNullOrEmpty(search2))
            {
                book = book.Where(s => s.Notes.Contains(search2));
            }

            Movie = await book.ToListAsync();

          


        }
    }
}
