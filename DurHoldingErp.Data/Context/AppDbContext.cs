using DurHoldingErp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Data.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext()
        {


        }
        public AppDbContext(DbContextOptions options) : base(options) {

        }
         
        public DbSet<Employee> employees { get; set; }

        public DbSet<Department> departments { get; set; }
      
    }
}
