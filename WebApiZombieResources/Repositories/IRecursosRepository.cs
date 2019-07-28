using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Repositories
{
    interface IRecursosRepository
    {
        IEnumerable<Recursos> GetRecursos();
        Recursos GetRecursos(int id);
        void CreateRecurso(Recursos recursos);
        void UpdateRecurso(Recursos recursos, int id);
        void DeleRecurso(int id);
    }
}
