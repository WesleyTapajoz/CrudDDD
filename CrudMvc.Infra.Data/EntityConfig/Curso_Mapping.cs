using CrudMvc.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CrudMvc.Infra.Data.EntityConfig
{
    public class Curso_Mapping : EntityTypeConfiguration<Curso>
    {
        public Curso_Mapping()
        {
            Property(x => x.Descricao)
            .HasMaxLength(800);
        }
    }
}
