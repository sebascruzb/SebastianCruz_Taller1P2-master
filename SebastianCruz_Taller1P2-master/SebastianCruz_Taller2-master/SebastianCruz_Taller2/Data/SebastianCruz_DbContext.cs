using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SebastianCruz_Taller2.Models;


    public class SebastianCruz_DbContext : DbContext
    {
        public SebastianCruz_DbContext(DbContextOptions<SebastianCruz_DbContext> options)
            : base(options)
        {
        }

        public DbSet<SebastianCruz_Taller2.Models.Burger> Burger { get; set; } = default!;
        public DbSet<SebastianCruz_Taller2.Models.Promo> Promo { get; set; } = default!;
    }
