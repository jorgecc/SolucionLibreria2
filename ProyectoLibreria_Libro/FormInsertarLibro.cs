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

namespace ProyectoLibreria_Libro
{
    public partial class FormInsertarLibro : Form
    {
        public FormInsertarLibro()
        {
            InitializeComponent();
            var lista= CategoriaDal.Listar();
            
            checkedListBoxCategorias.DataSource = lista;
            // tiene que usarse despues del datasource
            checkedListBoxCategorias.DisplayMember = "Nombre";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var libro = new Libro();
            var listaCat = new List<Categoria>();

            foreach (Categoria item in checkedListBoxCategorias.CheckedItems)
            {
                listaCat.Add(item);
            }


           


            libro = LibroConvertir.CrearLibro(textBoxISBN.Text,
                textBoxTitulo.Text, textBoxDescripcion.Text,
                numericUpDownPrecio.Value, listaCat);
            LibroDal.Insertar(libro);
        }
    }
}
