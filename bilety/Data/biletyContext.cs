#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bilety.Models;

namespace bilety.Data
{
    public class biletyContext : DbContext
    {
        public biletyContext (DbContextOptions<biletyContext> options)
            : base(options)
        {
        }

        public DbSet<bilety.Models.ticket> ticket { get; set; }

        public DbSet<bilety.Models.user> user { get; set; }

        public DbSet<bilety.Models.orders> orders { get; set; }

        public DbSet<bilety.Models.report> report { get; set; }
    }
}
