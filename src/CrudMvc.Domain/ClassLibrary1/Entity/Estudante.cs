using System;
using System.Collections.Generic;
using System.Text;

namespace CrudMvc.Domain.Entity
{
    public class Estudante
    {
        public int EstudanteId { get; set; }
        public string Nome { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public DateTime DataNascimento { get; set; }
        public byte[] Foto { get; set; }
        public int NivelEnsinoId { get; set; }
        public NivelEnsino NivelEnsino { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
