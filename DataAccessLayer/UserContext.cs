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

        public DbSet<sales> Sales { get; set; }
        public DbSet<Cars> Carss { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<clients> clientss { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>()
                .HasOptional(car => car.Model)
                .WithMany(model => model.carss)
                .HasForeignKey(car => car.ModelId);

            modelBuilder.Entity<sales>()
                .HasOptional(car => car.Clients)
                .WithMany(model => model.sale)
                .HasForeignKey(car => car.ClientsId);
        }


        //public class SoccerContext : DbContext
        //{
        //    public SoccerContext()
        //        : base("SoccerContext")
        //    { }
        //    public DbSet<Cars> carss { get; set; }
        //    public DbSet<CarModel> carModels { get; set; }
        //    public DbSet<sales> Sales { get; set; }
        //    public DbSet<clients> Clients { get; set; }
        //    /*
        //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<Cars>()
        //            .HasRequired(c => c.Carsales)
        //            .WithRequiredPrincipal(c => c.cars);

        //        modelBuilder.Entity<Cars>()
        //            .HasOptional(p => p.ModelId)
        //            .WithOptionalDependent()
        //            .Map(p => p.MapKey("ModelKey"));

        //        modelBuilder.Entity<CarModel>()
        //            .HasOptional(c => c.Carss)
        //            .WithOptionalPrincipal()
        //            .Map(c => c.MapKey("Idkey"));

        //        modelBuilder.Entity<sales>()
        //           .HasOptional(p => p.ClientId)
        //           .WithOptionalDependent()
        //           .Map(p => p.MapKey("clientkey"));

        //        modelBuilder.Entity<clients>()
        //            .HasOptional(c => c.sale)
        //            .WithOptionalPrincipal()
        //            .Map(c => c.MapKey("Phonekey"));

        //        base.OnModelCreating(modelBuilder);
        //    }
        //    */

        //}
    }
}
