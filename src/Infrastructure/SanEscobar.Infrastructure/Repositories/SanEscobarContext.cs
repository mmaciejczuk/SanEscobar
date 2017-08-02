using Microsoft.EntityFrameworkCore;
using SanEscobar.Domain.Core2;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanEscobar.Infrastructure.Repositories
{
    public class SanEscobarContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SanEscobarDB;Integrated Security=True");        
        }
    }
}