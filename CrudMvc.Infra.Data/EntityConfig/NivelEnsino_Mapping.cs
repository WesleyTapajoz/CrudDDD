using CrudMvc.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace CrudMvc.Infra.Data.EntityConfig
{
  public  class NivelEnsino_Mapping : EntityTypeConfiguration<NivelEnsino>
    {
        public NivelEnsino_Mapping()
        {
            ToTable("Escolaridade");
            Property(p => p.Descricao).IsRequired();
            Property(p => p.Descricao).HasMaxLength(300);
            HasKey(p => p.NivelEnsinoId);

            HasMany(e => e.Estudantes)
            .WithRequired(n => n.NivelEnsino)
            .HasForeignKey(n => n.NivelEnsinoId)
            .WillCascadeOnDelete(false);
        }
    }
}
