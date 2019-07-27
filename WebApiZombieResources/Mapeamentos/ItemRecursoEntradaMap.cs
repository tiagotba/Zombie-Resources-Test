using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Mapeamentos
{
    public sealed class ItemRecursoEntradaMap : EntityTypeConfiguration<ItemRecursoEntrada>
    {
        public ItemRecursoEntradaMap()
        {
            ToTable("TB_ITEM_RECURSO_ENTRADA");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("ID_RECURSO_ENTRADA")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.RecursoID)
               .HasColumnName("REC_ID")
               .IsRequired();

            Property(x => x.ItemRecursoID)
              .HasColumnName("ITEM_REC_ID")
              .IsRequired();

            Property(x => x.Lote)
               .HasColumnName("ITEM_LOTE")
               .IsRequired()
                .HasMaxLength(20);

            Property(x => x.Qtd)
              .HasColumnName("QTD_LOTE")
              .IsRequired();

            HasRequired(x => x.Recurso)
               .WithMany(x => x.ItemRecursoEntradas)
               .HasForeignKey(c => c.RecursoID);

            HasRequired(x => x.RecursoEntradas)
               .WithMany(x => x.ItemRecursoEntradas)
               .HasForeignKey(c => c.ItemRecursoID);

        }
    }
}