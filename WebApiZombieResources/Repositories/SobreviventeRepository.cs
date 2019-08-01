using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Attributes;
using WebApiZombieResources.Autenticacao;
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
            sobreviventes.HashSeguranca = (new Senha(sobreviventes.HashSeguranca).crypt);
            context.Sobreviventes.Add(sobreviventes);
            context.SaveChanges();
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

        Sobreviventes ISobreviventeRepository.GetByLogin(Sobreviventes sobrevivente)
        {
            return context.Sobreviventes.Where(s => s.LoginName == sobrevivente.LoginName).FirstOrDefault();
        }

        void ISobreviventeRepository.UpdateSobrevivente(Sobreviventes sobreviventes, int id)
        {
            throw new NotImplementedException();
        }


        IEnumerable<KeyValuePair<string, string>> ISobreviventeRepository.Validar(Sobreviventes sobreviventes)
        {
            var errors = new List<KeyValuePair<string, string>>();

            if (String.IsNullOrWhiteSpace(sobreviventes.Nome))
            {
                errors.Add(new KeyValuePair<string, string>("Nome", "Preencha o nome"));
            }

            if (String.IsNullOrWhiteSpace(sobreviventes.HashSeguranca))
            {
                errors.Add(new KeyValuePair<string, string>("Senha", "Preencha a Senha"));
            }

            if (String.IsNullOrWhiteSpace(sobreviventes.LoginName))
            {
                errors.Add(new KeyValuePair<string, string>("Login", "Preencha o Login"));
            }

            if (sobreviventes.Idade == 0)
            {
                errors.Add(new KeyValuePair<string, string>("Idade", "Preencha a idade"));
            }

            return errors;
        }
    }
}