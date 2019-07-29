using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Attributes;
using WebApiZombieResources.Contexts;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Repositories
{
    public class SobreviventeRepository : ISobreviventeRepository
    {
        [Dependency]
        public BD_Context context { get; set; }

        void ISobreviventeRepository.AddSobrevivente(Sobreviventes sobreviventes)
        {
            throw new NotImplementedException();
        }

        void ISobreviventeRepository.DeleSobrevivente(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Sobreviventes> ISobreviventeRepository.GetSobreviventes()
        {
            return context.Sobreviventes.ToList();
        }

        Sobreviventes ISobreviventeRepository.GetSobreviventes(int id)
        {
            return context.Sobreviventes.Where(r => r.Id == id).FirstOrDefault();
        }

        void ISobreviventeRepository.UpdateSobrevivente(Sobreviventes sobreviventes, int id)
        {
            throw new NotImplementedException();
        }
    }
}