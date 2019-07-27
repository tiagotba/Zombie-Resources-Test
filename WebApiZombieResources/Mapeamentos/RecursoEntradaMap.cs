using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Mapeamentos
{
    public sealed class RecursoEntradaMap : EntityTypeConfiguration<RecursoEntrada>
    {
        public RecursoEntradaMap()
        {
            ToTable("TB_RECURSO_ENTRADA");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("ID_RECURSO_ENTRADA")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.dataEntrada)
                .HasColumnName("DT_ENTRADA")
                .IsRequired();

            Property(x => x.dataPedido)
               .HasColumnName("DT_PEDIDO")
               .IsRequired();

            Property(x => x.Total)
              .HasColumnName("TOTAL_ENTRADA")
              .IsRequired();

            Property(x => x.SobreviventeID)
                .HasColumnName("SOBRV_ID")
                .IsRequired();

            HasRequired(x => x.Sobrevivente)
                .WithMany(x => x.recursoEntradas)
                .HasForeignKey(c => c.SobreviventeID);


        }
    }
}