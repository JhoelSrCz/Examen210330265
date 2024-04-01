using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaConsulta.VISTA.ConsultaVista
{
    public partial class TotalProductosVendidosVista : Form
    {
        public TotalProductosVendidosVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void TotalProductosVendidosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentaBss();
        }
    }
}
