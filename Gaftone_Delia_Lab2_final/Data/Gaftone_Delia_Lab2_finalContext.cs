using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gaftone_Delia_Lab2_final.Models;

namespace Gaftone_Delia_Lab2_final.Data
{
    public class Gaftone_Delia_Lab2_finalContext : DbContext
    {
        public Gaftone_Delia_Lab2_finalContext (DbContextOptions<Gaftone_Delia_Lab2_finalContext> options)
            : base(options)
        {
        }

        public DbSet<Gaftone_Delia_Lab2_final.Models.Book> Book { get; set; } = default!;

        public DbSet<Gaftone_Delia_Lab2_final.Models.Publisher>? Publisher { get; set; }

        public DbSet<Gaftone_Delia_Lab2_final.Models.Author>? Author { get; set; }
    }
}
