using System;
using System.Collections.Generic;

namespace CrudMvc.Domain.Entity
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataEncerramento { get; set; }
        public virtual ICollection<Estudante> Estudantes { get; set; }
    }
}

