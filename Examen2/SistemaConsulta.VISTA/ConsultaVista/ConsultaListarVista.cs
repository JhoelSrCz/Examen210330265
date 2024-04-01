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
    public partial class ConsultaListarVista : Form
    {
        public ConsultaListarVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarClientesVista listarClientes = new ListarClientesVista();
            listarClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListarIngresoProveedorVista listarIngresoProveedor = new ListarIngresoProveedorVista();
            listarIngresoProveedor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MarcaMasVendidaVista marcaMasVendida = new MarcaMasVendidaVista();
            marcaMasVendida.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CantidadTotalProductosVista cantidadTotalProductos = new CantidadTotalProductosVista();
            cantidadTotalProductos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FechaVencimientoVista fechaVencimiento = new FechaVencimientoVista();
            fechaVencimiento.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NombreCantidadProductosVista nombreCantidad = new NombreCantidadProductosVista();
            nombreCantidad.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IngresosGeneradosClienteVista ingresosGenerados = new IngresosGeneradosClienteVista();
            ingresosGenerados.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProveedorMasProductosVista proveedorMasProductos = new ProveedorMasProductosVista();
            proveedorMasProductos.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TotalProductosVendidosVista totalProductos = new TotalProductosVendidosVista();
            totalProductos.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ComprasMontoSuperiorVista comprasMontoSuperior = new ComprasMontoSuperiorVista();
            comprasMontoSuperior.Show();
        }
    }
}
