using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Mapeamentos
{
    public sealed class RecursoSaidaMap : EntityTypeConfiguration<RecursoSaida>
    {
        public RecursoSaidaMap()
        {
            ToTable("TB_RECURSO_SAIDA");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("ID_RECURSO_SAIDA")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.dataSaida)
                .HasColumnName("DT_SAIDA")
                .IsRequired();

            Property(x => x.dataPedido)
               .HasColumnName("DT_PEDIDO")
               .IsRequired();

            Property(x => x.Total)
              .HasColumnName("TOTAL_SAIDA")
              .IsRequired();

            Property(x => x.SobreviventeID)
                .HasColumnName("SOBRV_ID")
                .IsRequired();

            HasRequired(x => x.Sobrevivente)
                .WithMany(x => x.recursosSaidas)
                .HasForeignKey(c => c.SobreviventeID);


        }
    }
}