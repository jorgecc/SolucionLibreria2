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
using Librerias.convertir;
using Librerias.dal;

namespace ProyectoLibreria_Venta
{
    public partial class FormIngresarVenta : Form
    {
        public FormIngresarVenta()
        {
            InitializeComponent();
            comboBoxCliente.DataSource = ClienteDal.Listar();
            comboBoxLibro.DataSource = LibroDal.Listar();
            
        }

        private void comboBoxLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Libro libro = (Libro)comboBoxLibro.SelectedValue;

            textBoxPrecio.Text = libro.Precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string rut = ((Cliente)comboBoxCliente.SelectedValue).Rut;
            string isbn = ((Libro) comboBoxLibro.SelectedValue).ISBN;
            string precio = textBoxPrecio.Text;

            Venta v=new Venta();
            v = VentaConvertir.CrearVenta(rut, isbn, precio);

            var ok = VentaDal.Insertar(v);
            if (ok)
            {
                MessageBox.Show("Se inserto correctamente", "Venta"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo insertar", "Venta"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
    }
}
