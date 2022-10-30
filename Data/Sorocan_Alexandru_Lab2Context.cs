using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sorocan_Alexandru_Lab2.Models;

namespace Sorocan_Alexandru_Lab2.Data
{
    public class Sorocan_Alexandru_Lab2Context : DbContext
    {
        public Sorocan_Alexandru_Lab2Context (DbContextOptions<Sorocan_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sorocan_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Sorocan_Alexandru_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Sorocan_Alexandru_Lab2.Models.Authors> Authors { get; set; }
    }
}
