using CrudMvc.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CrudMvc.Infra.Data.EntityConfig
{
    public class Estudante_Mapping : EntityTypeConfiguration<Estudante>
    {
        public Estudante_Mapping()
        {
            //Configura one-to-zero-or-one
            HasOptional(end => end.Endereco)
           .WithRequired(est => est.Estudante);

            HasMany(e => e.Cursos)
                .WithMany(e => e.Estudantes)
                .Map(ce => {
                    ce.MapLeftKey("EstudanteId");
                    ce.MapRightKey("CursoId");
                    ce.ToTable("EstudanteCurso");
                });

            //MapToStoredProcedures();
            //MapToStoredProcedures(
            //        p =>
            //             p.Insert(spi =>
            //                      spi.HasName("spInserirEstudante")
            //                        .Parameter(pmi => pmi.Nome, "nome")
            //                        .Result(ri => ri.EstudanteId, "estudanteId")
            //                     )
            //             .Update(spu => spu.HasName("spAtualizarEstudante")
            //                             .Parameter(pmu => pmu.Nome, "nome"))
            //             .Delete(spd => spd.HasName("spExcluirEstudante")
            //                             .Parameter(pmd => pmd.EstudanteId, "estudanteId"))

            //    );
        }
    }
}
