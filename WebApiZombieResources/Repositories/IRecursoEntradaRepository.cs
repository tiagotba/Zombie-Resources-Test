using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Repositories
{
   public interface IRecursoEntradaRepository
    {
        void RegistraEntrada(RecursoEntrada recursoEntrada);
    }
}
