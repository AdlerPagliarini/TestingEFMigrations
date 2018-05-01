using DatabaseModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.DataContext
{
    public class DataMyContext : DbContext
    {
        public DataMyContext(DbContextOptions<DataMyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarroAcessorioNN>().HasKey(t => new { t.CarroId, t.AcessorioId });
        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Acessorio> Acessorio { get; set; }
    }
}
