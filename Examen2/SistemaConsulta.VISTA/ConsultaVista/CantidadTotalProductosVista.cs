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
    public partial class CantidadTotalProductosVista : Form
    {
        public CantidadTotalProductosVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void CantidadTotalProductosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductoBss();
        }
    }
}
