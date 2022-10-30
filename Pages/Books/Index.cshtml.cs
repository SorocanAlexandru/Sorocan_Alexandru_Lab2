using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sorocan_Alexandru_Lab2.Data;
using Sorocan_Alexandru_Lab2.Models;

namespace Sorocan_Alexandru_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Sorocan_Alexandru_Lab2.Data.Sorocan_Alexandru_Lab2Context _context;

        public IndexModel(Sorocan_Alexandru_Lab2.Data.Sorocan_Alexandru_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
            .Include(b => b.Publisher)
            .Include(c => c.Author)
            .ToListAsync();

        }
    }
}
