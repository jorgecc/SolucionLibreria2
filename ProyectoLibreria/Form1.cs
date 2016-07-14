using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
