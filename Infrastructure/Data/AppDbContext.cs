using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Serie> Series { get; set; }
        public DbSet<UserSerie> UserSeries { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
