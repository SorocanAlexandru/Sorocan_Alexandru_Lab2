using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sorocan_Alexandru_Lab2.Data;
using Sorocan_Alexandru_Lab2.Models;

namespace Sorocan_Alexandru_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Sorocan_Alexandru_Lab2.Data.Sorocan_Alexandru_Lab2Context _context;

        public CreateModel(Sorocan_Alexandru_Lab2.Data.Sorocan_Alexandru_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID",
   "PublisherName");
            ViewData["AuthorsID"] = new SelectList(_context.Set<Authors>(), "ID",
   "Authors");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
