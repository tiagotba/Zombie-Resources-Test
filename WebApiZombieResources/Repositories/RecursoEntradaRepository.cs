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
    public class RecursoEntradaRepository : IRecursoEntradaRepository
    {
        [Dependency]
        public BD_Context context { get; set; }

        void IRecursoEntradaRepository.RegistraEntrada(RecursoEntrada recursoEntrada)
        {

            using (DbContextTransaction transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.RecursoEntradas.Add(recursoEntrada);
                    context.SaveChanges();

                    foreach (var itemEntrada in recursoEntrada.ItemRecursoEntradas)
                    {
                        //itemEntrada.RecursoEntradas.ItemRecursoEntradas = null;
                        //itemEntrada.RecursoEntradas = recursoEntrada;
                        //context.ItemRecursoEntradas.Add(itemEntrada);
                        //context.SaveChanges();
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