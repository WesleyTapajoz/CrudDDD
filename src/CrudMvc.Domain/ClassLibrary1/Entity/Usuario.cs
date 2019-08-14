﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CrudMvc.Domain.Entity
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public NivelAcessoSistema NivelAcesso { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime UltimoAcesso { get; set; }
        public bool Bloqueado { get; set; }
    }
}
