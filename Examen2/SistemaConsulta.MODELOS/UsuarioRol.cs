﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsulta.MODELOS
{
    public class UsuarioRol
    {
        public int IdUsuarioRol { get; set; }
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public DateTime FechaAsigna { get; set; }
        public string Estado { get; set; }
    }
}
