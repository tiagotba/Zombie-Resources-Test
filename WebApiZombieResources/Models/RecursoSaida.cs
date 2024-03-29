﻿using System;
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
        public double Total { get; set; }
        public int SobreviventeID { get; set; }
        public virtual Sobreviventes Sobrevivente { get; set; }
        public virtual List<ItemRecursoSaida> ItemRecursoSaidas { get; set; }
    }
}