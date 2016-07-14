using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLibreria_Cliente;
using ProyectoLibreria_Libro;
using ProyectoLibreria_Venta;

namespace ProyectoLibreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario=new AboutBox1();
            formulario.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form=new FormIngresarVenta();
            form.ShowDialog();
        }

        private void listarVentasPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form=new FormListarVentaPorCliente();
            form.ShowDialog();

        }

        private void listarVentasPorLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormVentaXLibro();
            form.ShowDialog();
        }

        private void agregarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form=new FormInsertarLibro();
            form.ShowDialog();
        }

        private void listarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form=new FormListarLibros();
            form.ShowDialog();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form=new FormInsertarCliente();
            form.ShowDialog();
        }

        private void listarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form=new FormListarClientes();
            form.ShowDialog();
        }
    }
}
