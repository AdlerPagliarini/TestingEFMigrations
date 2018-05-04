using DatabaseModel.Models;
using DatabaseModel.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.DataContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarAccessoryNNConfiguration());
            modelBuilder.ApplyConfiguration(new PersonCarNNConfiguration());
            //modelBuilder.Entity<PessoaCarroNN>().HasKey(t => new { t.PessoaId, t.CarroId });
            //modelBuilder.Entity<CarroAcessorioNN>().HasKey(t => new { t.CarroId, t.AcessorioId });
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Accessory> Accessory { get; set; }
    }
}
