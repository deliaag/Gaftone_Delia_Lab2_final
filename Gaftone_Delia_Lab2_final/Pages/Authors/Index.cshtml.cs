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
    public class IndexModel : PageModel
    {
        private readonly Gaftone_Delia_Lab2_final.Data.Gaftone_Delia_Lab2_finalContext _context;

        public IndexModel(Gaftone_Delia_Lab2_final.Data.Gaftone_Delia_Lab2_finalContext context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author != null)
            {
                Author = await _context.Author.ToListAsync();
            }
        }
    }
}
