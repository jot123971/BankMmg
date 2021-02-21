using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankMmg.Models;

namespace BankMmg.Data
{
    public class BankMmgContext : DbContext
    {
        public BankMmgContext (DbContextOptions<BankMmgContext> options)
            : base(options)
        {
        }

        public DbSet<BankMmg.Models.BankSystem> BankSystem { get; set; }
    }
}
