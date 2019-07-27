using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Mapeamentos
{
    public sealed class ItemRecursoSaidaMap : EntityTypeConfiguration<ItemRecursoSaida>
    {
        public ItemRecursoSaidaMap()
        {
            ToTable("TB_ITEM_RECURSO_SAIDA");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("ID_RECURSO_SAIDA")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.RecursoID)
               .HasColumnName("REC_ID")
               .IsRequired();

            Property(x => x.ItemRecursoID)
              .HasColumnName("ITEM_REC_ID")
              .IsRequired();

            Property(x => x.Qtd)
              .HasColumnName("QTD_SAIDA")
              .IsRequired();

            HasRequired(x => x.Recurso)
               .WithMany(x => x.ItemRecursoSaidas)
               .HasForeignKey(c => c.RecursoID);

            HasRequired(x => x.RecursoSaidas)
               .WithMany(x => x.ItemRecursoSaidas)
               .HasForeignKey(c => c.ItemRecursoID);

        }
    }
}