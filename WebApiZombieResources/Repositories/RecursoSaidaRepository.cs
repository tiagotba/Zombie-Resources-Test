using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Unity.Attributes;
using WebApiZombieResources.Contexts;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Repositories
{
    public class RecursoSaidaRepository : IRecursoSaidaRepository
    {
        [Dependency]
        public BD_Context context { get; set; }

        void IRecursoSaidaRepository.RegistraSaida(RecursoSaida recursoSaida)
        {
            using (DbContextTransaction transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.RecursoSaidas.Add(recursoSaida);
                    context.SaveChanges();

                    foreach (var itemSaida in recursoSaida.ItemRecursoSaidas)
                    {
                      
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }

            }
        }
    }
}