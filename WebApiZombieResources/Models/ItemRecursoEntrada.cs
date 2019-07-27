using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiZombieResources.Models
{
    public class ItemRecursoEntrada
    {
        public int Id { get; set; }
        public virtual Recursos Recurso { get; set; }
        public string Lote { get; set; }
        public int Qtd { get; set; }

    }
}