using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gaftone_Delia_Lab2_final.Data;
using Gaftone_Delia_Lab2_final.Models;

namespace Gaftone_Delia_Lab2_final.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Gaftone_Delia_Lab2_final.Data.Gaftone_Delia_Lab2_finalContext _context;

        public DetailsModel(Gaftone_Delia_Lab2_final.Data.Gaftone_Delia_Lab2_finalContext context)
        {
            _context = context;
        }

      public Author Author { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}
