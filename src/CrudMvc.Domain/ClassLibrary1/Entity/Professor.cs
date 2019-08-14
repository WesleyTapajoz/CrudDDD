using System;
using System.Collections.Generic;
using System.Text;

namespace CrudMvc.Domain.Entity
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string Nome { get; set; }
        public int TipoProfessor { get; set; }
        public int NivelEnsinoId { get; set; }
        public NivelEnsino NivelEnsino { get; set; }
    }
}
