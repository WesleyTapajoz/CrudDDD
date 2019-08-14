using System;
using System.Collections.Generic;
using System.Text;

namespace CrudMvc.Domain.Entity
{
   public class NivelEnsino
    {
        public int NivelEnsinoId { get; set; }
        public string Descricao { get; set; }
        //virtual para Lazy Loading
        public virtual ICollection<Estudante> Estudantes { get; set; }
        public virtual ICollection<Professor> Professores { get; set; }
    }
}
