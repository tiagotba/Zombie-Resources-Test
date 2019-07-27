using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApiZombieResources.Models;

namespace WebApiZombieResources.Mapeamentos
{
    public sealed class SobreviventesMap : EntityTypeConfiguration<Sobreviventes>
    {
        public SobreviventesMap()
        {
            ToTable("TB_SOBREVIVENTES");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("ID_SOBREVIVENTE")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasColumnName("NOME")
                .IsRequired()
                .HasMaxLength(150);

            Property(x => x.Idade)
                .HasColumnName("IDADE")
                .IsRequired();

            Property(x => x.Genero)
               .HasColumnName("GENERO")
               .IsRequired()
            .HasMaxLength(2);

            Property(x => x.LoginName)
               .HasColumnName("LOGIN")
               .IsRequired()
            .HasMaxLength(20);

            Property(x => x.EAdmin)
               .HasColumnName("ADMIN")
               .IsRequired();

            HasMany(c => c.recursoEntradas)
          .WithRequired(c => c.Sobrevivente)
          .HasForeignKey(c => c.SobreviventeID);

            HasMany(c => c.recursosSaidas)
         .WithRequired(c => c.Sobrevivente)
         .HasForeignKey(c => c.SobreviventeID);

           
        }
    }
}