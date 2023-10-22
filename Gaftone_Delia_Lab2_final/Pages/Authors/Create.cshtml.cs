using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Gaftone_Delia_Lab2_final.Data;
using Gaftone_Delia_Lab2_final.Models;

namespace Gaftone_Delia_Lab2_final.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Gaftone_Delia_Lab2_final.Data.Gaftone_Delia_Lab2_finalContext _context;

        public CreateModel(Gaftone_Delia_Lab2_final.Data.Gaftone_Delia_Lab2_finalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Author == null || Author == null)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
