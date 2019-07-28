using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using Unity;
using Unity.Attributes;
using WebApiZombieResources.Contexts;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Repositories
{
    public class RecursoRepository : IRecursosRepository
    {
        [Dependency]
        public BD_Context context { get; set; }

        void IRecursosRepository.CreateRecurso(Recursos recursos)
        {
            context.Recursos.Add(recursos);
            context.SaveChanges();
        }

        void IRecursosRepository.DeleRecurso(int id)
        {
            Recursos recurso = context.Recursos.Find(id);
            context.Entry(recurso).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

        IEnumerable<Recursos> IRecursosRepository.GetRecursos()
        {
            return context.Recursos.ToList();
        }

        Recursos IRecursosRepository.GetRecursos(int id)
        {
            return context.Recursos.Where(r => r.Id == id).FirstOrDefault();
        }

        void IRecursosRepository.UpdateRecurso(Recursos recurso, int id)
        {
            
            context.Set<Recursos>().AddOrUpdate(recurso);
            context.SaveChanges();
        }
    }
}