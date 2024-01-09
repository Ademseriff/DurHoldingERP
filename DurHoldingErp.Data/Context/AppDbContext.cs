using DurHoldingErp.Entity.Entities;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DurHoldingErp.Entity.Entities;


namespace DurHoldingErp.Data.Context
{
    /// <summary>
    /// veritabanı bağlantı classı
    /// </summary>
    public class AppDbContext : DbContext
    {

        public AppDbContext()
        {


        }
        public AppDbContext(DbContextOptions options) : base(options) {

        }
         
        public DbSet<Employee> employees { get; set; }

        public DbSet<Department> departments { get; set; }

        public DbSet<Users> users { get; set; }

        //assembly dediğmiz şey bizim şu an içinde bulunduğumuz katmanı ifade eder ve bu kullanmış olduğumuz fonksiyon .GetExecutingAssembly() mapping işlemlerini bu katmandaki bütün sınıflar için uygular
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
