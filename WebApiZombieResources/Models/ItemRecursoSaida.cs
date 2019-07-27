using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiZombieResources.Models
{
    public class ItemRecursoSaida
    {
        public int Id { get; set; }
        public virtual Recursos Recurso { get; set; }
        public virtual RecursoSaida RecursoSaidas { get; set; }
        public int Qtd { get; set; }
    }
}