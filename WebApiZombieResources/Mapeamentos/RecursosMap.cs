using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Mapeamentos
{
    public sealed class RecursosMap : EntityTypeConfiguration<Recursos>
    {
        public RecursosMap()
        {
            ToTable("TB_RECURSOS");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("ID_RECURSO")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
                .HasColumnName("DESC_DESCRICAO")
                .IsRequired()
                 .HasMaxLength(150);

            Property(x => x.Quantidade)
           .HasColumnName("QTD_ESTOQUE")
           .IsRequired();
         

            Property(x => x.Observacao)
           .HasColumnName("OBS_OBSERVACAO")
           .IsRequired()
            .HasMaxLength(500);

        }
    }
}