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
    public partial class IngresosGeneradosClienteVista : Form
    {
        public IngresosGeneradosClienteVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void IngresosGeneradosClienteVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonaBss();
        }
    }
}
