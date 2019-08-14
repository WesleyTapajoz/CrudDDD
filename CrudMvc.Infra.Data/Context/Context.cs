using CrudMvc.Domain.Entity;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;

namespace CrudMvc.Infra.Data.Context
{
    public class Context : DbContext
    {

        public Context() : base("")
        {

        }
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<NivelEnsino> NiveisDeEnsino { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("Varchar"));
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(200));
            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("Varchar"));

            var targetAssembly = Assembly.GetExecutingAssembly();
            var subtypes = targetAssembly.GetTypes().Where(t => t.Name.EndsWith("_Mapping"));
            foreach (var item in subtypes)
            {
                dynamic configurationInstance = Activator.CreateInstance(item);
                modelBuilder.Configurations.Add(configurationInstance);
            }

        }

    }
}
