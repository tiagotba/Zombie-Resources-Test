using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiZombieResources.Models
{
    public class RecursoEntrada
    {
        public int Id { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataPedido { get; set; }
        public double Total { get; set; }
        public virtual Sobreviventes Sobrevivente { get; set; }
        public virtual List<ItemRecursoEntrada> ItemRecursoEntradas { get; set; }

    }
}