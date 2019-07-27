using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Contexts
{
    public class BD_Context : DbContext
    {
        public BD_Context() : base("name=SurvivorDBConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<BD_Context>(null);
        }

        public DbSet<Recursos> Recursos { get; set; }
        public DbSet<Sobreviventes> Sobreviventes { get; set; }
        public DbSet<RecursoEntrada> RecursoEntradas { get; set; }
        public DbSet<RecursoSaida> RecursoSaidas { get; set; }
        public DbSet<ItemRecursoEntrada> ItemRecursoEntradas { get; set; }
        public DbSet<ItemRecursoSaida> ItemRecursoSaidas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Mapeamentos.RecursosMap());
            modelBuilder.Configurations.Add(new Mapeamentos.SobreviventesMap());
            modelBuilder.Configurations.Add(new Mapeamentos.RecursoEntradaMap());
            modelBuilder.Configurations.Add(new Mapeamentos.RecursoSaidaMap());
            modelBuilder.Configurations.Add(new Mapeamentos.ItemRecursoEntradaMap());
            modelBuilder.Configurations.Add(new Mapeamentos.ItemRecursoSaidaMap());
        }
    }
}