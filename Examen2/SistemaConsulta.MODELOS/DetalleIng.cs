﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsulta.MODELOS
{
    public class Detalleing
    {
        public int IdDetalleing { get; set; }
        public int IdIngreso { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVenc { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal SubTotal { get; set; }
        public string Estado { get; set; }
    }
}
