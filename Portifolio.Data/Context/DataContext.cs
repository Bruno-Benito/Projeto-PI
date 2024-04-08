using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portifolio.Domain.Models;

namespace Portifolio.Data.Context
{
    public class DataContext : DbContext
    {
          public DataContext(DbContextOptions<DataContext> options) : base(options) { }
          public DbSet<User> User {get; set;}
          public DbSet<Site> Site {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}