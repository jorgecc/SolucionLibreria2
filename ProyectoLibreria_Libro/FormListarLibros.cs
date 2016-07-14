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

namespace ProyectoLibreria_Libro
{
    public partial class FormListarLibros : Form
    {
        public FormListarLibros()
        {
            InitializeComponent();
            var lista= CategoriaDal.Listar();
            var cat = new Categoria();
            cat.IdCategoria = 0;
            cat.Nombre = "--Seleccione Valor--";
            lista.Insert(0,cat);

            comboBoxCategoria.DataSource = lista;



        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria cat = (Categoria) comboBoxCategoria.SelectedItem;

            var lista = LibroDal.Listar(cat.IdCategoria);
            dataGridView1.DataSource = lista;
        }
    }
}
