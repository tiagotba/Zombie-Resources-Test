﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Repositories
{
   public interface ISobreviventeRepository
    {
        IEnumerable<Sobreviventes> GetSobreviventes();
        Sobreviventes GetSobreviventes(int id);
        Sobreviventes GetByLogin(Sobreviventes sobrevivente);
        IEnumerable<KeyValuePair<string, string>> Validar(Sobreviventes sobreviventes);
        void AddSobrevivente(Sobreviventes sobreviventes);
        void UpdateSobrevivente(Sobreviventes sobreviventes, int id);
        void DeleSobrevivente(int id);
    }
}
