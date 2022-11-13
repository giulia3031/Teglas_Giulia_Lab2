using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Teglas_Giulia_Lab2.Models;

    public class cs : DbContext
    {
        public cs (DbContextOptions<cs> options)
            : base(options)
        {
        }

        public DbSet<Teglas_Giulia_Lab2.Models.Book> Book { get; set; } = default!;
    }
