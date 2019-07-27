using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiZombieResources.Models
{
    public class RecursoSaida
    {
        public int Id { get; set; }
        public DateTime dataSaida { get; set; }
        public DateTime dataPedido { get; set; }
        public virtual Sobreviventes Sobrevivente { get; set; }
    }
}