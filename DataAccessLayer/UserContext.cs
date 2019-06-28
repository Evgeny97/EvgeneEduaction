using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class UserContext : DbContext
    {
        const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DbCars;Integrated Security=True";

        public UserContext()
            : base(connectionString)
        { }
        
        public DbSet<sales> sale { get; set; }
        public DbSet<Cars> Carss { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<clients> clientss { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
                modelBuilder.Entity<Cars>()
                  .HasRequired(c => c.sale)
              .WithOptional(c => c.CarAvto);
            

            base.OnModelCreating(modelBuilder);
        }

    }
}
