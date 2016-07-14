using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librerias;
using Librerias.dal;

namespace ProyectoLibreria_Venta
{
    public partial class FormVentaXLibro : Form
    {
        public FormVentaXLibro()
        {
            InitializeComponent();

            comboBoxLibro.DataSource = LibroDal.Listar();

        }

        private void comboBoxLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string isbn = ((Libro)comboBoxLibro.SelectedValue).ISBN;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = VentaDal.ListaXLibro(isbn);

        }
    }
}
