﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsulta.MODELOS
{
    public class Ingreso
    {
        public int IdIngreso { get; set; }
        public int IdProveedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
    }
}
